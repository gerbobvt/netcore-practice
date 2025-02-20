using Gerbob.Training;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

Console.WriteLine();

var hostBuilder = Host.CreateDefaultBuilder();

hostBuilder.ConfigureServices(services => {
    services.AddSingleton<IHackerApplication, HackerApplication>();
    services.AddTransient<IAlgos, Algos>();
    });

var host = hostBuilder.Build();

var app = host.Services.GetRequiredService<IHackerApplication>();

var algos = host.Services.GetRequiredService<IAlgos>();

var logger = host.Services.GetService<ILogger<Program>>();

// Console.Write("How many hacks for hacks per second you require? ");
// var requestedHacks = Console.ReadLine();

// if (requestedHacks is not null && uint.TryParse(requestedHacks, out var hacks))
// {
//     var isHacked = app.HackThePlanet(hacks);

//     logger.LogInformation($"Planet has{(isHacked ? " " : " not ")}been hacked.");
// }
// else 
// {
//     logger.LogError("lrn2hack n00b!");
// }

// Console.Write("Pick a number: ");
// var requestedNumber = Console.ReadLine();

// if (requestedNumber is not null && int.TryParse(requestedNumber, out var size))
// {
//     logger.LogInformation($"Finding primes up to {size}");
//     var primes = algos.GetPrimesLessThan(size);
//     logger.LogInformation($"Found {primes.Count} primes");

//     foreach (var prime in primes)
//     {
//         Console.WriteLine(prime);
//     }
// }
// else
// {
//     logger.LogError("Learn to follow directions.");
// }

Console.Write("Enter a number: ");
var a = NumberFromInput(Console.ReadLine() ?? "");

Console.Write("Enter another number: ");
var b = NumberFromInput(Console.ReadLine() ?? "");

Console.WriteLine($"Add {a} + {b} = {BrainTeasers.Add(a, b)}");
Console.WriteLine($"Fancy Add {a} + {b} = {BrainTeasers.FancyAdd(a, b)}");


int NumberFromInput(string input)
{
    if (input is not null && int.TryParse(input, out var number))
    {
        return number;
    }

    throw new ArgumentException("Input is not a number.");
}
