using CSharp.GunSimulator.Models;

namespace CSharp.GunSimulator;

public class Program
{
    static void Main(string[] args)
    {
        IGun gun1 = new IGun();
        gun1.Type = "AK-47";
        gun1.MagazineCapacity = "7.62";
        gun1.BulletCountInMagazine = 30;
        gun1.BulletFiredInOneMillisecond = 1;
        gun1.AutomaticModeFiring(33);
    }
}