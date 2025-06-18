using Fiddler.Factories;
using Fiddler.Like_System;
using Fiddler.Models;
using Fiddler.Services;

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
            var partsService = new PartsService();
            var robotService = new RobotService();
            var carService = new CarService();

            var factory = new Factory(partsService, robotService, carService);

            Console.WriteLine("Building robots:");
            var robotDog = factory.BuildVehicle<Robot>(RobotType.RoboticDog);
            Console.WriteLine($"Built Robotic Dog: {robotDog != null}");

            var robotCat = factory.BuildVehicle<Robot>(RobotType.RoboticCat);
            Console.WriteLine($"Built Robotic Cat: {robotCat != null}");

            Console.WriteLine("\nBuilding cars:");
            var toyota = factory.BuildVehicle<Car>(CarType.Toyota);
            Console.WriteLine($"Built Toyota: {toyota != null}");

            var ford = factory.BuildVehicle<Car>(CarType.Ford);
            Console.WriteLine($"Built Ford: {ford != null}");

            Console.WriteLine("\nTrying to build unknown type:");
            var unknown = factory.BuildVehicle<Robot>((RobotType)99);
            Console.WriteLine($"Result: {unknown?.GetType().Name ?? "null"}");
        }
    }
}
