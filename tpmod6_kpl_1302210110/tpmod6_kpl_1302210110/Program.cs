// See https://aka.ms/new-console-template for more information


public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;


    public SayaTubeVideo(string judul)
    {
        this.title = judul;
        this.id = id;
        Random o = new Random(id);
        var x = o.Next(0, 100000);
        string s = x.ToString("00000");
        this.playCount = new int();
        playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        this.playCount = playCount;
        playCount++;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("tampilkan nama " + this.id + " judul " + this.title + " playcount " + this.playCount);
    }


}

public class program
{
    public void main(string[] args)
    {
        Console.WriteLine("masukan judul");
        String judul = Console.ReadLine();
        SayaTubeVideo utub = new SayaTubeVideo(judul);
        int play = Console.Read();
        utub.IncreasePlayCount(play);
        utub.PrintVideoDetails();


    }
}






