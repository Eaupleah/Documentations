namespace CSharp.DesignPatterns.Models;

public class SportsPackageDecorator : CarDecorator
{
    public SportsPackageDecorator(ICar car) : base(car)
    {
    }

    public override string Description => $"{base.Description}, added Sports Package Upgrade";
    public override double Price => base.Price + 6500;
}