using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using WeatherAppVSA.RealTimeApi;
using WeatherAppVSA.Shared;

namespace WeatherAppVSA.RealTime
{
    public class RealTimeService : IRealTimeService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public RealTimeService(WeatherApiClient weatherClient, IOptions<WeatherApiOptions> options)
        {
            _httpClient = weatherClient.Client;
            _apiKey = options.Value.ApiKey;
        }

        public async Task<RealTimeDto> GetCurrentWeatherAsync(string location)
        {
            if (string.IsNullOrWhiteSpace(location))
            {
                throw new ArgumentException("Location cannot be null or whitespace.", nameof(location));
            }

            HttpResponseMessage response = await _httpClient.GetAsync($"current.json?key={_apiKey}&q={location}");
            response.EnsureSuccessStatusCode();
            string jsonResponse = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<RealTimeDto>(jsonResponse) ?? throw new InvalidOperationException("Failed to desirialize the JSON response");
        }
    }
}
