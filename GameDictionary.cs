using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ZwiftPower
{
	public class GameDictionary
	{
		static GameDictionary()
		{
			string fileName = "GameDictionary.json";
			string jsonString = File.ReadAllText(fileName);

			var options = new JsonSerializerOptions
			{
				NumberHandling = JsonNumberHandling.AllowReadingFromString,
				IncludeFields = true,
			};

			options.Converters.Add(new UnixDateTimeConverter());
			options.Converters.Add(new NumberBooleanConverter());
			options.Converters.Add(new NullableNumberAsStringConverter());
			options.Converters.Add(new NullableFloatAsStringConverter());
			options.Converters.Add(new IntAsStringArrayConverter());

			Data = JsonSerializer.Deserialize<GameDictionaryData>(jsonString, options);
		}

		public static GameDictionaryData Data;
	}

	public record GameDictionaryData(
		Dictionary.Route[] Routes,
		Dictionary.Segment[] Segments,
		Dictionary.ImageItem[] Jerseys,
		Dictionary.ImageItem[] RunShirts,
		Dictionary.ImageItem[] RunShorts,
		Dictionary.ImageItem[] RunShoes,
		Dictionary.ImageItem[] BikeShoes,
		Dictionary.ImageItem[] BikeFrontWheels,
		Dictionary.ImageItem[] BikeRearWheels,
		Dictionary.BikeFrame[] BikeFrames,
		Dictionary.Item[] PaintJobs,
		Dictionary.ImageItem[] Socks,
		Dictionary.ImageItem[] Glasses,
		Dictionary.ImageItem[] HeadGear,
		Dictionary.ImageItem[] Achievements,
		Dictionary.ImageItem[] Challenges,
		Dictionary.NotableMomentType[] NotableMomentTypes,
		Dictionary.ImageItem[] TrainingPlans,
		Dictionary.Item[] UnlockableCategories
		);

	namespace Dictionary
	{
		public record Item(
			string name,
			string signature);

		public record ImageItem(
			string imageName,
			string name,
			string signature
			) : Item(name, signature);

		public record BikeFrame(
			string isTT,
			string modelYear,
			string name,
			string signature) : Item(name, signature);

		public record NotableMomentType(
			string imageName,
			string name,
			string priority,
			string signature
		) : ImageItem(imageName, name, signature);

		public record Route(
			string ascentBetweenFirstLastLrCPsInMeters,
			string ascentInMeters,
			string blockedForMeetups,
			string difficulty,
			string distanceBetweenFirstLastLrCPsInMeters,
			string distanceInMeters,
			string duration,
			string eventOnly,
			string eventPaddocks,
			string freeRideLeadinAscentInMeters,
			string freeRideLeadinDistanceInMeters,
			string imageName,
			string leadinAscentInMeters,
			string leadinDistanceInMeters,
			string levelLocked,
			string locKey,
			string map,
			string meetupLeadinAscentInMeters,
			string meetupLeadinDistanceInMeters,
			string name,
			string sports,
			string supportedLaps,
			string supportsTimeTrialMode,
			string xp,
			long signature,
			long routeSignature,
			string defaultLeadinAscentInMeters,
			string defaultLeadinDistanceInMeters,
			string rowRec,
			string runRec,
			string bikeRec,
			string bikeType
		);

		public record Segment(
			string archFriendlyFemaleNameR,
			string archFriendlyNameR,
			string archId,
			string direction,
			string jerseyIconPath,
			string name,
			string roadId,
			string roadTime,
			string world,
			string signature,
			string jerseyName,
			string onRoutes
		);
	}
}
