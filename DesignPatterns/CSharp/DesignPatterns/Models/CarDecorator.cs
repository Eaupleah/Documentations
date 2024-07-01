namespace CSharp.DesignPatterns.Models;

public class CarDecorator : ICar
{
    protected ICar _car;

    public CarDecorator(ICar car)
    {
        this._car = car;
    }

    public virtual string Description => _car.Description;
    public virtual string Model => _car.Model;
    public virtual int Year => _car.Year;
    public virtual string EngineType => _car.EngineType;
    public virtual string FuelType => _car.FuelType;
    public virtual double Price => _car.Price;

    public double calculatePrice()
    {
        return Price;
    }
}