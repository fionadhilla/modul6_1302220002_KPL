public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> listVideo;
    private String username;

    public SayaTubeUser(string username)
    {
        if (string.IsNullOrEmpty(username))
            throw new ArgumentNullException("Judul video tidak boleh null.");
        //if (title.Length > 100)
        //    throw new ArgumentOutOfRangeException("Panjang judul video maksimal 100 karakter.");

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.username = username;
        listVideo = new List<SayaTubeVideo>();
    }

    public int GetTotalVideoPlayCount()
    {
        int hasil = 0;
        for (int i = 0; i < listVideo.Count; i++) {
            hasil = hasil + listVideo[i].getPlayCount();
        }
        return hasil;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        listVideo.Add(video);
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine($"User: {username}");

        for (int i = 0; i < listVideo.Count; i++)
        {
            Console.WriteLine($"Video {i+1} judul: {listVideo[i].getTitle()}");
        }

    }


}