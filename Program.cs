using Fiddler.Contracts;
using Fiddler.Factories;
using Fiddler.Like_System;
using Fiddler.Models;
using Fiddler.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Fiddler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Likes System Demo
            var likesCounter = new LikesCounter();
            var names = new List<string> { "Alice", "Bob", "Charlie", "David", "Mthunzi" };
            var result = likesCounter.Likes(names); 
            Console.WriteLine(result);

            //Refactoring Demo
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IPartsService, PartsService>()
                .AddSingleton<IRobotService, RobotService>()
                .AddSingleton<ICarService, CarService>()
                .AddSingleton<Factory>()
                .BuildServiceProvider();

            var factory = serviceProvider.GetRequiredService<Factory>();

            // Build vehicles
            Console.WriteLine("Building robots:");
            var robotDog = factory.BuildVehicle<Robot>(RobotType.RoboticDog);
            Console.WriteLine($"Built {robotDog.GetType()}");

            var robotCat = factory.BuildVehicle<Robot>(RobotType.RoboticCat);
            Console.WriteLine($"Built {robotCat.GetType()}");

            Console.WriteLine("\nBuilding cars:");
            var toyota = factory.BuildVehicle<Car>(CarType.Toyota);
            Console.WriteLine($"Built {toyota.GetType()}");

            var ford = factory.BuildVehicle<Car>(CarType.Ford);
            Console.WriteLine($"Built {ford.GetType()}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
