using System;

public class SayaMusicTrack
{
    private int id;
    private string playCount;
    private string title;

    public SayaMusicTrack (string title)
    {
        this.title = title;
        Random random = new Random();
        this.id = random.Next(10000, 1000000);

        this.playCount = "0";
    }

    public void IncreasePlayCount (int count)
    {
        int currentCount = int.Parse(this.playCount);
        currentCount += count;

        this.playCount = currentCount.ToString();
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine($"ID MusikTrack    : {this.id}");
        Console.WriteLine($"Title       : {this.title}");
        Console.WriteLine($"Play Count  : {this.playCount}");
    }
}

public class program
{
    public static void Main(string[] args)
    {
        SayaMusicTrack trackini = new SayaMusicTrack("Bintang 5 - tenxi");

        Console.WriteLine("======= Detail Lagu Saat Ini =======");
        trackini.PrintTrackDetails();

        trackini.IncreasePlayCount(50000);

        Console.WriteLine("\n====== Detail Lagu Setelah Update ======");
        trackini.PrintTrackDetails();
    }
}