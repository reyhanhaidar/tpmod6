// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;


    public SayaTubeVideo(string judul)
    {
        this.title = judul;
        this.id = o;
        Random o = new Random();
        var x = o.Next(0, 100000);
        string s = x.ToString("00000");
        this.playCount = new int;
        playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        this.playCount = playCount;
        int count = 0;
        count = playCount++;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("tampilkan nama " + this.id + " judul " + this.title + " playcount " + IncreasePlayCount(int i);
    }

 }
    
