using EfCoreDemo.API.DbContexts;
using EfCoreDemo.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EfCoreDemo.API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };


       

    public WeatherForecastController(EFcoreDbContext context)
    {
        Context = context;
    }

    public EFcoreDbContext Context { get; }

    [HttpGet(Name = "GetWeatherForecast")]
    public User Get()
    {
       return Context.User.FirstOrDefault();
    }
}
