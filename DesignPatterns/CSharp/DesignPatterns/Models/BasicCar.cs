namespace CSharp.DesignPatterns.Models;

public class BasicCar : ICar
{
    private string description;
    private string model;
    private int year;
    private string engineType;
    private string fuelType;
    private decimal price;
    public string Description { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string EngineType { get; set; }
    public string FuelType { get; set; }
    public double Price { get; set; }

    public BasicCar(string description, string model, int year, string engineType, string fuelType, double price)
    {
        this.Description = description;
        this.Model = model;
        this.Year = year;
        this.EngineType = engineType;
        this.FuelType = fuelType;
        this.Price = price;
    }

    public double calculatePrice()
    {
        return this.Price;
    }
}