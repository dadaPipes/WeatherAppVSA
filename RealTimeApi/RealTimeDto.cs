using Newtonsoft.Json;
using WeatherAppVSA.Shared;

namespace WeatherAppVSA.RealTime
{
    public record RealTimeDto(
        [JsonProperty("location")] LocationData Location,
        [JsonProperty("current")] CurrentData Current
        );
}
