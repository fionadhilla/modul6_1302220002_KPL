using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title))
            throw new ArgumentNullException("Judul video tidak boleh null.");
        if (title.Length > 200)
            throw new ArgumentOutOfRangeException("Panjang judul video maksimal 100 karakter.");
        
       

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }



    public void IncreasePlayCount(int increaseAmount)
    {
        if (increaseAmount < 0)
            throw new ArgumentOutOfRangeException("Penambahan play count tidak boleh negatif");
       
        //playCount += increaseAmount;

        try
        {
            checked
            {
                playCount += increaseAmount;
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Terjadi overflow pada play count: {ex.Message}");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }

    public int getPlayCount()
    {
        return playCount;
    }

    public string getTitle()
    {
        return title;
    }

    public static void Main(string[] args)
    {
        //string namaPraktikan = "FIONADHILLA";
        //string judulVideo = $"Review  Film - {namaPraktikan}";

        SayaTubeUser user = new SayaTubeUser("Fionadhilla");

        SayaTubeVideo video = new SayaTubeVideo("Review film A oleh Fionadhilla");
        video.IncreasePlayCount(1234567890);
        user.AddVideo(video);
        SayaTubeVideo video2 = new SayaTubeVideo("Review film B oleh Fionadhilla");
        user.AddVideo(video2);
        SayaTubeVideo video3 = new SayaTubeVideo("Review film C oleh Fionadhilla");
        user.AddVideo(video3);
        SayaTubeVideo video4 = new SayaTubeVideo("Review film D oleh Fionadhilla");
        user.AddVideo(video4);
        SayaTubeVideo video5 = new SayaTubeVideo("Review film E oleh Fionadhilla");
        user.AddVideo(video5);
        SayaTubeVideo video6 = new SayaTubeVideo("Review film F oleh Fionadhilla");
        user.AddVideo(video6);
        SayaTubeVideo video7 = new SayaTubeVideo("Review film G oleh Fionadhilla");
        user.AddVideo(video7);
        SayaTubeVideo video8 = new SayaTubeVideo("Review film H oleh Fionadhilla");
        user.AddVideo(video8);
        SayaTubeVideo video9 = new SayaTubeVideo("Review film I oleh Fionadhilla");
        user.AddVideo(video9);
        SayaTubeVideo video10 = new SayaTubeVideo("Review film J oleh Fionadhilla");
        user.AddVideo(video10);
        user.PrintAllVideoPlayCount();

        //video.IncreasePlayCount(1234567890);
        //video.getPlayCount();

        //video.IncreasePlayCount(10);
        //video.PrintVideoDetails();

        //try
        //{
        //    SayaTubeVideo video = new SayaTubeVideo(judulVideo);

         //   video.IncreasePlayCount(12);
        //    video.PrintVideoDetails();
        //}
       // catch (ArgumentNullException ex)
        //{
        //    Console.WriteLine(ex.Message);
       // }
       // catch (ArgumentOutOfRangeException ex)
       // {
        //    Console.WriteLine(ex.Message);
       // }
    }
}
