using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ZwiftPower
{
	public class UnixDateTimeConverter : JsonConverter<DateTime>
	{
		internal static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

		public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			long seconds;

			if (reader.TokenType == JsonTokenType.Number)
			{
				seconds = reader.GetInt64();
			}
			else if (reader.TokenType == JsonTokenType.String)
			{
				if (long.TryParse(reader.GetString(), out seconds) == false)
				{
					throw new JsonException("Cannot convert to UNIX DateTime");
				}
			}
			else
			{
				throw new JsonException("Unexpected token parsing date");
			}

			if (seconds > 0)
			{
				return UnixEpoch.AddSeconds(seconds);
			}
			else
			{
				throw new JsonException("Cannot convert value that is before the UNIX epoch");
			}
		}

		public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
		{
			throw new NotImplementedException();
		}
	}

	public class NumberBooleanConverter : JsonConverter<bool>
	{
		public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.Number)
			{
				return reader.GetInt32() == 1;
			}

			if (reader.TokenType == JsonTokenType.String)
			{
				if (int.TryParse(reader.GetString(), out int value) == false)
				{
					throw new JsonException("Invalid boolean value");
				}

				return value == 1;
			}

			throw new JsonException("Expected string or number");
		}

		public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
		{
			throw new NotImplementedException();
		}
	}

	public class NullableNumberAsStringConverter : JsonConverter<int?>
	{
		public override int? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.Number)
			{
				return reader.GetInt32();
			}

			if (reader.TokenType == JsonTokenType.String)
			{
				var value = reader.GetString();

				return value == string.Empty ? null : int.Parse(value);
			}

			throw new JsonException("Expected empty string or number");
		}

		public override void Write(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
		{
			throw new NotImplementedException();
		}
	}

	public class NullableFloatAsStringConverter : JsonConverter<float?>
	{
		public override float? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.Number)
			{
				return reader.GetSingle();
			}

			if (reader.TokenType == JsonTokenType.String)
			{
				var value = reader.GetString();

				return value == string.Empty ? null : float.Parse(value);
			}

			throw new JsonException("Expected empty string or number");
		}

		public override void Write(Utf8JsonWriter writer, float? value, JsonSerializerOptions options)
		{
			throw new NotImplementedException();
		}
	}

	public class IntAsStringArrayConverter : JsonConverter<int[]>
	{
		public override int[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			List<int> values = new();

			if (reader.TokenType == JsonTokenType.StartArray)
			{
				while (reader.Read())
				{
					if (reader.TokenType == JsonTokenType.Number)
					{
						values.Add(reader.GetInt32());
					}
					else if (reader.TokenType == JsonTokenType.String)
					{
						var value = reader.GetString();

						if (value == string.Empty)
						{
							values.Add(default);
						}
						else
						{
							values.Add(int.Parse(value));
						}
					}
					else if (reader.TokenType == JsonTokenType.EndArray)
					{
						break;
					}
					else
					{
						throw new JsonException("Expected number or string or end of array");
					}
				}
			}

			return values.ToArray();
		}

		public override void Write(Utf8JsonWriter writer, int[] value, JsonSerializerOptions options)
		{
			throw new NotImplementedException();
		}
	}
}
