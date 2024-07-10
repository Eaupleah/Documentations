using CSharp.GunSimulator.Models;

namespace CSharp.GunSimulator;

public class Program
{
    static void Main(string[] args)
    {
        IGun gun1 = new IGun();
        gun1.Type = "AK-47";
        gun1.MagazineCapacity = "7.62";
        gun1.BulletCountInMagazine = 23;
        gun1.FiredBulletsPerMillisecond = -1;
        gun1.AutomaticModeFiring(33);
    }
}