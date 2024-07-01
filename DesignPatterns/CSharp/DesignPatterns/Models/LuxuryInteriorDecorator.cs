namespace CSharp.DesignPatterns.Models;

public class LuxuryInteriorDecorator : CarDecorator
{
    public LuxuryInteriorDecorator(ICar car) : base(car)
    {
    }

    public override string Description => $"{base.Description}, added Luxery Interior Upgrade";
    public override double Price => _car.Price + 3000;
}