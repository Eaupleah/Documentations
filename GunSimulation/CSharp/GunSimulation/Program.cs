using CSharp.GunSimulation.Models;

namespace CSharp.GunSimulation;

public class Program
{
    static void Main(string[] args)
    {
        Gun gun1 = new Gun();
        gun1.Type = "AK-47";
        gun1.MagazineCapacity = "7.62";
        gun1.BulletCountInMagazine = 23;
        gun1.FiredBulletsPerMillisecond = 1;
        gun1.AutomaticModeFiring(33);
    }
}