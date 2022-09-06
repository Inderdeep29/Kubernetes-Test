using Content.Helpers;
using Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace Content.Controllers;

[ApiController]
[Route("[controller]")]
public class ContentController : ControllerBase
{
    private readonly ILogger<ContentController> _logger;
    private readonly DataContext _context;

    public ContentController(ILogger<ContentController> logger, DataContext dbContext)
    {
        _logger = logger;
        this._context = dbContext;

    }

    [HttpGet(template: "GetAdcvds")]
    public IEnumerable<Adcvd> GetAdcvds()
    {
        Console.WriteLine("HIT:GetAdcvds");
        return _context.Adcvds;
    }

    [HttpGet(template: "GetCountryLists")]
    public IEnumerable<CountryList> GetCountryLists()
    {
        Console.WriteLine("HIT:GetCountryLists");
        Thread.Sleep(10000);
		return _context.CountryLists;
    }

    [HttpGet(template: "GetWeatherTypes")]
    public IEnumerable<string> GetWeatherTypes()
    {
        Console.WriteLine("HIT:GetWeatherTypes");
        return new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
    }

    [HttpGet(template: "Test1")]
    public string GetTest1()
    {
        Console.WriteLine("HIT:GetTest1");
        return "Test1 return value";
    }

    [HttpGet(template: "Test2")]
    public string GetTest2()
    {
        Console.WriteLine("HIT:GetTest2");
        return "Test2 return value";
    }
}
