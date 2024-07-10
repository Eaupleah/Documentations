namespace CSharp.GunSimulator.Models;

public class IGun
{
    public string Type { get; set; }
    public string MagazineCapacity { get; set; }
    public int BulletCountInMagazine { get; set; }
    public int BulletFiredInOneMillisecond { get; set; }

    public void SemiAutomaticModeFiring(int bulletCount)
    {
        while (bulletCount > 0)
        {
            Console.WriteLine("Gun Fired");
            Console.WriteLine($"Remaining Bullets: {--bulletCount}");
            this.BulletCountInMagazine--;
            if (this.BulletCountInMagazine == 0)
            {
                Console.WriteLine("Reloading...");
                this.BulletCountInMagazine = 30;
            }
        }
    }

    public void AutomaticModeFiring(int millisecond)
    {
        int time = 0;
        int firedBullets = 0;
        while (this.BulletCountInMagazine > 0)
        {
            millisecond--;
            this.BulletCountInMagazine = this.BulletCountInMagazine - this.BulletFiredInOneMillisecond;
            firedBullets = firedBullets + this.BulletFiredInOneMillisecond;
            time++;
            if (millisecond <= 0 && this.BulletCountInMagazine > millisecond)
            {
                Console.WriteLine(
                    $"The bullets fired within the given time period: {firedBullets}, remaining bullets: {this.BulletCountInMagazine}");
                break;
            }
            else if (BulletCountInMagazine <= 0)
            {
                Console.WriteLine($"Finished. Duration: {time} seconds");
            }
        }
    }
}