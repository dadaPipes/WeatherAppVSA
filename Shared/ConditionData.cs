using Newtonsoft.Json;

namespace WeatherAppVSA.Shared
{
    public record ConditionData(
        [JsonProperty("text")] string Text,
        [JsonProperty("icon")] string Icon,
        [JsonProperty("code")] int Code
    );
}
