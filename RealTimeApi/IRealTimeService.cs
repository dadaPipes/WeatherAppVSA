using WeatherAppVSA.RealTime;

namespace WeatherAppVSA.RealTimeApi
{
    public interface IRealTimeService
    {
        Task<RealTimeDto> GetCurrentWeatherAsync(string location);
    }
}
