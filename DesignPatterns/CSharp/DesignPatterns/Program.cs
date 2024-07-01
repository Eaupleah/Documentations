using CSharp.DesignPatterns.Models;

namespace CSharp.DesignPatterns;

public class Program
{
    static void Main(string[] args)
    {
        ICar bmwX5 = new BasicCar("BMW X5 SUV", "BMW X5", 2023, "Inline-6 Turbocharged", "Gasoline", 60000);
        ICar sportsPackageCar = new SportsPackageDecorator(bmwX5);
        ICar luxuryInteriorCar = new LuxuryInteriorDecorator(sportsPackageCar);

        Console.WriteLine($"Description of the car before upgrades: {bmwX5.Description}");
        Console.WriteLine($"Price of the car before upgrades: {bmwX5.Price}");

        Console.WriteLine($"Description after the sports package upgrade: {sportsPackageCar.Description}");
        Console.WriteLine($"Price after the sports package update: {sportsPackageCar.Price}");

        Console.WriteLine($"Description after the luxury interior upgrade: {luxuryInteriorCar.Description}");
        Console.WriteLine($"Price after the luxury interior upgrade: {luxuryInteriorCar.Price}");
    }
}