namespace CSharp.GunSimulator.Models;

public class IGun
{
    private int _bulletCountInMagazine;
    private int _firedBulletsPerMillisecond;

    public string Type { get; set; }

    public string MagazineCapacity { get; set; }

    public int BulletCountInMagazine
    {
        get { return _bulletCountInMagazine; }
        set
        {
            if (value < 0)
            {
                throw new Exception("Magazine capacity must be positive");
            }
            else
            {
                _bulletCountInMagazine = value;
            }
        }
    }

    public int FiredBulletsPerMillisecond
    {
        get { return _firedBulletsPerMillisecond;}
        set
        {
            if (value < 0)
            {
                throw new Exception("Fired bullets per millisecond must be positive");
            }
            else
            {
                _firedBulletsPerMillisecond = value;
            }
        }
    }

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
            this.BulletCountInMagazine = this.BulletCountInMagazine - this.FiredBulletsPerMillisecond;
            firedBullets = firedBullets + this.FiredBulletsPerMillisecond;
            time++;
            if (millisecond <= 0 && this.BulletCountInMagazine > millisecond)
            {
                Console.WriteLine(
                    $"Bullets fired within the time period {firedBullets}, remaining bullets: {this.BulletCountInMagazine}");
                break;
            }
            else if (BulletCountInMagazine <= 0)
            {
                Console.WriteLine($"Finished. Duration: {time} seconds");
            }
        }
    }
}