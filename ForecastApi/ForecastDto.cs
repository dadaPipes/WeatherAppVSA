using Newtonsoft.Json;
using WeatherAppVSA.Shared;

namespace WeatherAppVSA.Forecast
{
  public record ForecastDto(
    [JsonProperty("location")] LocationData Location,
    [JsonProperty("current")] CurrentData Current,
    [JsonProperty("forecast")] ForecastData Forecast
  );

  public record CurrentData(
    [property: JsonProperty("last_updated_epoch")] long LastUpdatedEpoch,
    [property: JsonProperty("last_updated")] string LastUpdated,
    [property: JsonProperty("temp_c")] double TempC,
    [property: JsonProperty("temp_f")] double TempF,
    [property: JsonProperty("is_day")] int IsDay,
    [property: JsonProperty("condition")] Condition Condition,
    [property: JsonProperty("wind_mph")] double WindMph,
    [property: JsonProperty("wind_kph")] double WindKph,
    [property: JsonProperty("wind_degree")] int WindDegree,
    [property: JsonProperty("wind_dir")] string WindDir,
    [property: JsonProperty("pressure_mb")] double PressureMb,
    [property: JsonProperty("pressure_in")] double PressureIn,
    [property: JsonProperty("precip_mm")] double PrecipMm,
    [property: JsonProperty("precip_in")] double PrecipIn,
    [property: JsonProperty("humidity")] int Humidity,
    [property: JsonProperty("cloud")] int Cloud,
    [property: JsonProperty("feelslike_c")] double FeelslikeC,
    [property: JsonProperty("feelslike_f")] double FeelslikeF,
    [property: JsonProperty("vis_km")] double VisKm,
    [property: JsonProperty("vis_miles")] double VisMiles,
    [property: JsonProperty("uv")] double Uv,
    [property: JsonProperty("gust_mph")] double GustMph,
    [property: JsonProperty("gust_kph")] double GustKph
  );

  public record Condition(
    [JsonProperty("text")] string Text,
    [JsonProperty("icon")] string Icon,
    [JsonProperty("code")] int Code
  );
  public record ForecastData(
    [JsonProperty("forecastday")] List<ForecastDay> ForecastDay
  );
  public record ForecastDay(
    [JsonProperty("date")] string Date,
    [JsonProperty("date_epoch")] long DateEpoch,
    [JsonProperty("day")] Day Day,
    [JsonProperty("astro")] Astro Astro,
    [JsonProperty("hour")] List<Hour> Hour
  );

  public record Day(
    [JsonProperty("maxtemp_c")] double MaxTempC,
    [JsonProperty("maxtemp_f")] double MaxTempF,
    [JsonProperty("mintemp_c")] double MinTempC,
    [JsonProperty("mintemp_f")] double MinTempF,
    [JsonProperty("avgtemp_c")] double AvgTempC,
    [JsonProperty("avgtemp_f")] double AvgTempF,
    [JsonProperty("maxwind_mph")] double MaxWindMPH,
    [JsonProperty("maxwind_kph")] double MaxWindKPH,
    [JsonProperty("totalprecip_mm")] double TotalPrecipMM,
    [JsonProperty("totalprecip_in")] double TotalPrecipIN,
    [JsonProperty("totalsnow_cm")] double TotalSnowCM,
    [JsonProperty("avgvis_km")] double AvgVisKM,
    [JsonProperty("avgvis_miles")] double AvgVisMiles,
    [JsonProperty("avghumidity")] double AvgHumidity,
    [JsonProperty("daily_will_it_rain")] int DailyWillItRain,
    [JsonProperty("daily_chance_of_rain")] int DailyChanceOfRain,
    [JsonProperty("daily_will_it_snow")] int DailyWillItSnow,
    [JsonProperty("daily_chance_of_snow")] int DailyChanceOfSnow,
    [JsonProperty("condition")] Condition Condition,
    [JsonProperty("uv")] double UV
  );

  public record Astro(
    [JsonProperty("sunrise")] string Sunrise,
    [JsonProperty("sunset")] string Sunset,
    [JsonProperty("moonrise")] string Moonrise,
    [JsonProperty("moonset")] string Moonset,
    [JsonProperty("moon_phase")] string MoonPhase,
    [JsonProperty("moon_illumination")] int MoonIllumination,
    [JsonProperty("is_moon_up")] int IsMoonUp,
    [JsonProperty("is_sun_up")] int IsSunUp
  );

  public record Hour(
    [JsonProperty("time_epoch")] long TimeEpoch,
    [JsonProperty("time")] string Time,
    [JsonProperty("temp_c")] double TempC,
    [JsonProperty("temp_f")] double TempF,
    [JsonProperty("is_day")] int IsDay,
    [JsonProperty("condition")] Condition Condition,
    [JsonProperty("wind_mph")] double WindMPH,
    [JsonProperty("wind_kph")] double WindKPH,
    [JsonProperty("wind_degree")] int WindDegree,
    [JsonProperty("wind_dir")] string WindDir,
    [JsonProperty("pressure_mb")] double PressureMB,
    [JsonProperty("pressure_in")] double PressureIN,
    [JsonProperty("precip_mm")] double PrecipMM,
    [JsonProperty("precip_in")] double PrecipIN,
    [JsonProperty("snow_cm")] double SnowCM,
    [JsonProperty("humidity")] int Humidity,
    [JsonProperty("cloud")] int Cloud,
    [JsonProperty("feelslike_c")] double FeelsLikeC,
    [JsonProperty("feelslike_f")] double FeelsLikeF,
    [JsonProperty("windchill_c")] double WindChillC,
    [JsonProperty("windchill_f")] double WindChillF,
    [JsonProperty("heatindex_c")] double HeatIndexC,
    [JsonProperty("heatindex_f")] double HeatIndexF,
    [JsonProperty("dewpoint_c")] double DewPointC,
    [JsonProperty("dewpoint_f")] double DewPointF,
    [JsonProperty("will_it_rain")] int WillItRain,
    [JsonProperty("chance_of_rain")] int ChanceOfRain,
    [JsonProperty("will_it_snow")] int WillItSnow,
    [JsonProperty("chance_of_snow")] int ChanceOfSnow,
    [JsonProperty("vis_km")] double VisKM,
    [JsonProperty("vis_miles")] double VisMiles,
    [JsonProperty("gust_mph")] double GustMPH,
    [JsonProperty("gust_kph")] double GustKPH,
    [JsonProperty("uv")] double UV
  );
}
