using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using WeatherAppVSA.Shared;

namespace WeatherAppVSA.Forecast
{
    public class ForecastService : IForecastService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public ForecastService(WeatherApiClient weatherClient, IOptions<WeatherApiOptions> options)
        {
            _httpClient = weatherClient.Client;
            _apiKey = options.Value.ApiKey;
        }

        public async Task<ForecastDto> GetForecastAsync(string location)
        {
            if (string.IsNullOrWhiteSpace(location))
            {
                throw new ArgumentException("Location cannot be null or whitespace.", nameof(location));
            }

            HttpResponseMessage response = await _httpClient.GetAsync($"forecast.json?key={_apiKey}&days=10&q={location}");
            response.EnsureSuccessStatusCode();
            string jsonResponse = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ForecastDto>(jsonResponse) ?? throw new InvalidOperationException("Failed to desirialize the JSON response");
        }
    }
}
