namespace WeatherAppVSA.Shared
{
    public class WeatherApiClient
    {
        public HttpClient Client { get; }

        public WeatherApiClient(HttpClient client, IConfiguration configuration)
        {
            var baseUrl = configuration["WeatherApi:BaseUrl"];
            client.BaseAddress = new Uri(baseUrl!);
            Client = client;
        }
    }
}