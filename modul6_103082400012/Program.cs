namespace modul6_103082400012
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Review Film Dragon Ball");
            for (int i = 0; i < 100; i++)
            {
                video.IncreasePlayCount(20000000);
            }
            SayaTubeUser user = new SayaTubeUser("Fadhil Ganteng");
            user.addVideo(video);
            string nama = "Fadhil";

            user.addVideo(new SayaTubeVideo($"Review Film Bath-Man oleh                   : {nama}"));
            user.addVideo(new SayaTubeVideo($"Review Film Bath-Man 2 oleh                 : {nama}"));
            user.addVideo(new SayaTubeVideo($"Review Film Bath-Man 3 oleh                 : {nama}"));
            user.addVideo(new SayaTubeVideo($"Review Film The Amazing Bath-Man oleh       : {nama}"));
            user.addVideo(new SayaTubeVideo($"Review Film The Amazing Bath-Man 10 oleh    : {nama}"));
            user.addVideo(new SayaTubeVideo($"Review Film Bath-Man: BrokenHome oleh       : {nama}"));
            user.addVideo(new SayaTubeVideo($"Review Film Bath-Man: Far from Home oleh    : {nama}"));
            user.addVideo(new SayaTubeVideo($"Review Film Bath-Man: Jatuh  oleh           : {nama}"));
            user.addVideo(new SayaTubeVideo($"Review Film Bath-Man: Brand New Day oleh   : {nama}"));
            user.addVideo(new SayaTubeVideo($"Review Film Avengers: EndWorld oleh        : {nama}"));

            user.PrintAllVideoPlayCount();
        }
    }
}