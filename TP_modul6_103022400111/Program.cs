using System;
using System.Diagnostics;

public class SayaMusicTrack
{
    private int id;
    private string playCount;
    private string title;

    public SayaMusicTrack (string title)
    {
        Debug.Assert(title != null, "Judul track tidak boleh null.");
        Debug.Assert(title.Length <= 100, "Panjang judul track maksimal 100 karakter.");

        this.title = title;


        Random random = new Random();
        this.id = random.Next(10000, 1000000);

        this.playCount = "0";
    }

    public void IncreasePlayCount (int count)
    {
        Debug.Assert(count <= 10000000, "Penambahan play count tidak boleh lebih dari 10000000");

        try
        {
            checked
            {
                int currentPlayCount = int.Parse(this.playCount);
                currentPlayCount += count;
                this.playCount = currentPlayCount.ToString();
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Exception ditangkap: Penambahan play count gagal karena melebihi batas maksimum integer");
        }
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

        for (int i = 0; i <= 200; i++) {

            trackini.IncreasePlayCount(10000000);
            if (i % 15   == 0)
            {
                Console.WriteLine($"Proses ke-{i}: Penambahan berhasil...");
            }
        }

        Console.WriteLine("\n====== Detail Lagu Setelah Update ======");
        trackini.PrintTrackDetails();
    }
}