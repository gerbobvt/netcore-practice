using System;
using Microsoft.Extensions.Logging;

public interface IHackerApplication
{
    public bool HackThePlanet(uint howFast);
}

public class HackerApplication : IHackerApplication
{
    private readonly ILogger<HackerApplication> _logger;

    public HackerApplication(ILogger<HackerApplication> logger)
    {
        _logger = logger;
    }

    public bool HackThePlanet(uint howFast)
    {
        _logger.LogInformation($"Trying to go {howFast} hacks per second.");

        return howFast > uint.MaxValue / 2;
    }
}