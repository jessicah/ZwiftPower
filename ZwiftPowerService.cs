using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ZwiftPower
{
	public class ZwiftPowerService
	{
		private readonly HttpClient _httpClient;
		private readonly JsonSerializerOptions _options;
		private readonly IConfiguration _config;

		public HttpClient Client { get => _httpClient; }

		public ZwiftPowerService(HttpClient httpClient, IConfiguration configuration)
		{
			_httpClient = httpClient;
			_config = configuration;

			_options = new JsonSerializerOptions
			{
				NumberHandling = JsonNumberHandling.AllowReadingFromString,
				IncludeFields = true
			};

			_options.Converters.Add(new UnixDateTimeConverter());
			_options.Converters.Add(new NumberBooleanConverter());
			_options.Converters.Add(new NullableNumberAsStringConverter());
			_options.Converters.Add(new NullableFloatAsStringConverter());
			_options.Converters.Add(new IntAsStringArrayConverter());
		}

		private static long UnixTicks { get { return (DateTime.UtcNow - DateTime.UnixEpoch).Ticks; } }

		internal async Task<T> DeserializeUrl<T>(string url)
		{
			int retries = 10;

			Exception lastException = null;

			while (retries-- > 0)
			{
				try
				{
					return await _httpClient.GetFromJsonAsync<T>(url, _options);
				}
				catch (JsonException exn)
				{
					// usually because we're not logged in
					await Login();

					lastException = exn;
				}
				catch (HttpRequestException exn)
				{
					// maybe ZwiftPower is down, wait 30 seconds
					await Task.Delay(30000);

					lastException = exn;
				}
			}

			throw new TimeoutException($"Exceeded ZwiftPower retries for url: {url}", lastException);
		}

		internal T DeserializeString<T>(string json) => JsonSerializer.Deserialize<T>(json);

		public async Task Login()
		{
			if (string.IsNullOrEmpty(_config["Zwiftpower:Username"]))
			{
				throw new ArgumentException("ZwiftPower Username is required to login", "Zwiftpower:Username");
			}
			if (string.IsNullOrEmpty(_config["Zwiftpower:Password"]))
			{
				throw new ArgumentException("ZwiftPower password is required to login", "Zwiftpower:Password");
			}

			using FormUrlEncodedContent content = new FormUrlEncodedContent(new Dictionary<string, string>
			{
				{ "username", _config["Zwiftpower:Username"] },
				{ "password", _config["Zwiftpower:Password"] },
				{ "redirect", "./index.php" },
				{ "login", "" }
			});

			using var indexPage = await _httpClient.PostAsync("/ucp.php?mode=login", content);
		}

		internal class Data<T>
		{
#pragma warning disable 0649 // used by JSON deserialization
			public T[] data;
#pragma warning restore 0649

		}

		internal class DataArray<T>
		{
#pragma warning disable 0649 // used by JSON deserialization
			public T[][] data;
#pragma warning restore 0649

		}

		internal Task<TItem> ParseItemAsync<TItem>(string url) => DeserializeUrl<TItem>(url);

		internal async Task<IEnumerable<T>> ParseListAsync<T>(string url)
		{
			var result = await DeserializeUrl<Data<T>>(url);

			return result.data;
		}

		internal async Task<IEnumerable<T>> ParsePagedList<T>(string url)
		{
			var result = await DeserializeUrl<DataArray<T>>(url);

			return result.data.SelectMany(results => results);
		}

		public async Task SubmitResultChanges(int eventId, IEnumerable<ResultSubmission> bumped, IEnumerable<ResultSubmission> disqualified)
		{
			await Login();

			StringBuilder builder = new StringBuilder();

			foreach (var bump in bumped)
			{
				builder.AppendLine($"{bump.CalculatedCategory}, {bump.Flag}, {bump.PowerType}, {bump.TeamId}, {bump.Name}, {bump.Id}, {bump.Uid}, {bump.Penalty}, ");
			}

			foreach (var dq in disqualified)
			{
				builder.AppendLine($"{dq.CalculatedCategory}, {dq.Flag}, {dq.PowerType}, {dq.TeamId}, {dq.Name}, {dq.Id}, {dq.Uid}, {dq.Penalty}, ");
			}

			// replace escapes: html decode, then url encode (url encode taken care of; just need HTML entities escaped, and strip commas)
			using FormUrlEncodedContent content = new FormUrlEncodedContent(new Dictionary<string, string>
			{
				{ "edit_results", System.Net.WebUtility.HtmlDecode(builder.ToString()) }
			});

			await _httpClient.PostAsync($"/zz.php?do=edit_results&act=save&zwift_event_id={eventId}", content);
		}

		// API surface
		public Task<IEnumerable<PendingRequest>> PendingRequestsAsync() => ParseListAsync<PendingRequest>("/api3.php?do=team_pending&id=4");

		public Task<IEnumerable<Result>> ProfileResultsAsync(int zwid) => ParseListAsync<Result>($"/cache3/profile/{zwid}_all.json?_={UnixTicks}");

		public Task<IEnumerable<Signup>> EventSignupsAsync(int zid) => ParseListAsync<Signup>($"/cache3/results/{zid}_signups.json?_={UnixTicks}");

		public Task<IEnumerable<Events>> EventsAsync() => ParseListAsync<Events>("/cache3/lists/0_zwift_event_list_7.json");

		public Task<IEnumerable<EventResult>> EventResultsAsync(int zid) => ParseListAsync<EventResult>($"/cache3/results/{zid}_view.json?_={UnixTicks}");

		public Task<IEnumerable<FilteredResult>> FilteredResultsAsync(int zid) => ParseListAsync<FilteredResult>($"/cache3/results/{zid}_filtered.json?_={UnixTicks}");

		public Task<IEnumerable<Member>> TeamMembersAsync() => ParseListAsync<Member>("/api3.php?do=team_riders&id=4");

		public Task<IEnumerable<LiveResult>> LiveResultsAsync(int zid) => ParseListAsync<LiveResult>($"/...{zid}");

		public Task<IEnumerable<Event>> EventAsync() => ParseListAsync<Event>("/cache3/lists/0_zwift_event_list_3.json");

		public Task<IEnumerable<SeriesEvent>> SeriesEventsAsync(string series) => ParseListAsync<SeriesEvent>($"/api3.php?do=series_event_list&id={series}");

		public Task<IEnumerable<Segment>> EventSegmentsAsync(int zid, string category) => ParseListAsync<Segment>($"/api3.php?do=event_primes&zid={zid}&category={category}&prime_type=msec");
	}

	public class ResultSubmission
	{
		public int Id;
		public int TeamId;
		public string EnteredCategory;
		public string HistoricalCategory;
		public string CalculatedCategory;
		public string Name;
		public string Flag;
		public int PowerType;
		public string Uid;
		public int Penalty;
	}

	public record PendingRequest(
		string e,
		string email,
		string n,
		string aid,
		int tid,
		string tname,
		string tc,
		string tbc,
		string flag,
		int?[] ftp,
		float[] w,
		int zwid
	);

	public record Result(
		int zwid,
		string zid,
		string name,
		string flag,
		int? tid,
		string tname,
		string tc,
		string tbc,
		string tbd,
		int? div,
		int? divw,
		bool male,
		DateTime event_date,
		int distance,
		int[] avg_power,
		float time_gun
	);

	public record SeriesEvent(
		int DT_RowID,
		string cats,
		string t,
		DateTime tm,
		int zid
	);

	public record Signup(
		int? tid,
		int zwid,
		string name,
		DateTime tm
	);

	public record Events(
		string rt,
		string t,
		DateTime tm,
		int zid
	)
	{
		public string RouteName { get => Routes.RouteNames[rt]; }
		public Uri RouteLink { get => new Uri(Routes.RouteLinks[rt]); }
	}

	public record EventResultBase(
		string category,
		int div,
		int divw,
		string flag,
		bool male,
		DateTime event_date,
		string name,
		int pos,
		int position_in_cat,
		int power_type,
		string tbc,
		string tbd,
		string tc,
		int? tid,
		string tname,
		long uid,
		float? vtta,
		float vttat,
		int zid,
		int zwid
	);

	public record EventResult(
		string category,
		int div,
		int divw,
		string flag,
		bool male,
		DateTime event_date,
		string name,
		int pos,
		int position_in_cat,
		float[] time,
		float time_gun,
		int power_type,
		string tbc,
		string tbd,
		string tc,
		int? tid,
		string tname,
		long uid,
		float? vtta,
		float vttat,
		int[] wftp,
		float[] wkg_ftp,
		int zid,
		int zwid
	)
	: EventResultBase(category, div, divw, flag, male, event_date, name, pos, position_in_cat, power_type, tbc, tbd, tc, tid, tname, uid, vtta, vttat, zid, zwid)
	{
		// we need to return a *new* instance here, otherwise it will use EventResult equality, *not* EventResultBase equality
		public EventResultBase Base() => new EventResultBase(category, div, divw, flag, male, event_date, name, pos, position_in_cat, power_type, tbc, tbd, tc, tid, tname, uid, vtta, vttat, zid, zwid);

		public static bool SequenceEqual(IEnumerable<EventResult> left, IEnumerable<EventResult> right)
			=> Enumerable.SequenceEqual(left.Select(item => item.Base()), right.Select(item => item.Base()));
	}

	public record Member(
		int div,
		int divw,
		string email,
		int age,
		string aid,
		int climbed,
		int distance,
		int energy,
		string flag,
		int[] ftp,
		string h_15_watts,
		string h_15_wkg,
		string h_1200_watts,
		string h_1200_wkg,
		string name,
		string r,
		string rank,
		int reg,
		int skill,
		int skill_power,
		int skill_seg,
		string status,
		int time,
		float[] w,
		int zada,
		int zwid
	);

	public record LiveResult(
		int position,
		int pos_in_grp,
		int time_diff,
		int time_diff_cat,
		int div,
		bool male,
		string name
	);

	public record Event(
		int zid,
		DateTime tm
	);

	public record FilteredResult(
		 string category,
		 int div,
		 int divw,
		 string flag,
		 bool male,
		 string name,
		 string note,
		 int power_type,
		 string tbc,
		 string tbd,
		 string tc,
		 int? tid,
		 float[] time,
		 float time_gun,
		 string tname,
		 long uid,
		 int?[] w5,
		 int?[] w15,
		 int?[] w30,
		 int?[] w60,
		 int?[] w120,
		 int?[] w300,
		 int?[] w1200,
		 float[] weight,
		 int[] wftp,
		 float?[] wkg5,
		 float?[] wkg15,
		 float?[] wkg30,
		 float?[] wkg60,
		 float?[] wkg120,
		 float?[] wkg300,
		 float?[] wkg1200,
		 float[] wkg_ftp,
		 bool wkg_guess,
		 int zid,
		 int zwid
	);

	public record Segment(
		int id,
		int lap,
		string name,
		int sprint_id,
		SegmentRider rider_1,
		SegmentRider rider_2,
		SegmentRider rider_3,
		SegmentRider rider_4,
		SegmentRider rider_5,
		SegmentRider rider_6,
		SegmentRider rider_7,
		SegmentRider rider_8,
		SegmentRider rider_9,
		SegmentRider rider_10
	)
	{
		public List<SegmentRider> riders
		{
			get
			{
				var riders = new SegmentRider[] {
					rider_1, rider_2, rider_3, rider_4, rider_5, rider_6, rider_7, rider_8, rider_9, rider_10
				};

				return riders.Where(rider => rider != null).ToList();
			}
		}

		public bool IsLap { get => Segments.Laps.Contains((Segments.Segment)sprint_id); }
		public bool IsClimb { get => Segments.Climbs.Contains((Segments.Segment)sprint_id); }
		public bool IsSprint { get => Segments.Sprints.Contains((Segments.Segment)sprint_id); }

		public Segments.Segment Value { get => (Segments.Segment)sprint_id; }
	}

	public record SegmentRider(
		int age,
		int div,
		int divw,
		float elapsed,
		float elapsed_diff,
		string flag,
		int ftp,
		string gender,
		long msec,
		float msec_diff,
		string name,
		string tbc,
		string tbd,
		string tc,
		int tid,
		string tname,
		float w,
		int zwid
	);
}
