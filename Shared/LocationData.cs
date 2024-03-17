using Newtonsoft.Json;

namespace WeatherAppVSA.Shared
{
    public record LocationData(
        [JsonProperty("name")] string Name,
        [JsonProperty("region")] string Region,
        [JsonProperty("country")] string Country,
        [JsonProperty("lat")] float Latitude,
        [JsonProperty("lon")] float Longitude,
        [JsonProperty("tz_id")] string TimeZoneId,
        [JsonProperty("localtime_epoch")] int LocalTimeEpoch,
        [JsonProperty("localtime")] string LocalTime
    );
}
