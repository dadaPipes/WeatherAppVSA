using Microsoft.AspNetCore.Mvc;

namespace WeatherAppVSA.Forecast
{
    public class ForecastController : Controller
    {
      private readonly IForecastService _forecastService;
      public ForecastController(IForecastService forecastService)
      {
        _forecastService = forecastService;
      }
      public async Task<IActionResult> GetForecast(string local)
      {
        local = "Copenhagen";
        
        var forecast = await _forecastService.GetForecastAsync(local);
        if(forecast != null)
        {
          return View(forecast);
        }
        else
        {
          return View("Error");
        }
                  
      }
  }
}
