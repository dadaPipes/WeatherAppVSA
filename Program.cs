using WeatherAppVSA;
using WeatherAppVSA.Forecast;
using WeatherAppVSA.RealTime;
using WeatherAppVSA.RealTimeApi;
using WeatherAppVSA.Shared;

var builder = WebApplication.CreateBuilder(args);

// Configure settings
builder.Services.Configure<WeatherApiOptions>(builder.Configuration.GetSection("WeatherApi"));

// Add services to the container.

builder.Services.AddHttpClient<WeatherApiClient>();
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IRealTimeService, RealTimeService>();
builder.Services.AddScoped<IForecastService, ForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
