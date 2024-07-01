namespace CSharp.DesignPatterns.Models;

public interface ICar
{
    public double calculatePrice();
    public string Description { get; }
    public string Model { get; }
    public int Year { get; }
    public string EngineType { get; }
    public string FuelType { get; }
    public double Price { get; }
}