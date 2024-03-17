using Microsoft.AspNetCore.Mvc;
using WeatherAppVSA.RealTimeApi;

namespace WeatherAppVSA.RealTime
{
    public class RealTimeController : Controller
    {
        private readonly IRealTimeService _realTimeService;
        public RealTimeController(IRealTimeService realTimeService)
        {
            _realTimeService = realTimeService;
        }
        public async Task<IActionResult> GetCurrentWeather(string local)
        {
            local = "Copenhagen";
            var currentWeather = await _realTimeService.GetCurrentWeatherAsync(local);

            return View(currentWeather);
        }
    }
}
