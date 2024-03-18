using Newtonsoft.Json;
using WeatherAppVSA.Shared;

namespace WeatherAppVSA.RealTime
{
  public record RealTimeDto(
    [JsonProperty("location")] LocationData Location,
    [JsonProperty("current")] CurrentData Current
    );
  public record CurrentData(
    [JsonProperty("last_updated_epoch")] int LastUpdatedEpoch,
    [JsonProperty("last_updated")] string LastUpdated,
    [JsonProperty("temp_c")] float TemperatureCelsius,
    [JsonProperty("temp_f")] float TemperatureFahrenheit,
    [JsonProperty("feelslike_c")] float FeelsLikeCelsius,
    [JsonProperty("feelslike_f")] float FeelsLikeFahrenheit,
    [JsonProperty("condition")] ConditionData Condition,
    [JsonProperty("wind_mph")] float WindMPH,
    [JsonProperty("wind_kph")] float WindKPH,
    [JsonProperty("wind_degree")] int WindDegree,
    [JsonProperty("wind_dir")] string WindDirection,
    [JsonProperty("pressure_mb")] float PressureMillibars,
    [JsonProperty("pressure_in")] float PressureInches,
    [JsonProperty("precip_mm")] float PrecipitationMillimeters,
    [JsonProperty("precip_in")] float PrecipitationInches,
    [JsonProperty("humidity")] int Humidity,
    [JsonProperty("cloud")] int Cloud,
    [JsonProperty("is_day")] int IsDay,
    [JsonProperty("uv")] float UV
  )
  {
    [JsonIgnore]
    public float GustMPH { get; init; }
    [JsonIgnore]
    public float GustKPH { get; init; }
  };
  public record ConditionData(
    [JsonProperty("text")] string Text,
    [JsonProperty("icon")] string Icon,
    [JsonProperty("code")] int Code
  );
}
