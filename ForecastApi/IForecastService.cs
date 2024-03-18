namespace WeatherAppVSA.Forecast
{
    public interface IForecastService
    {
        Task<ForecastDto> GetForecastAsync(string location);
    }
}
