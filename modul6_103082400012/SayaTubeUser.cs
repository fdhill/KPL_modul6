using System;
using System.Collections.Generic;
using System.Text;

namespace modul6_103082400012
{
    public class SayaTubeUser
    {
        public int id;
        public List<SayaTubeVideo> stv;
        public string Username;

        public SayaTubeUser(string username)
        {
            this.Username = username;
            this.stv = new List<SayaTubeVideo>();
        }
        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (var video in stv)
            {
                total += video.playCount;
            }
            return total;
        }
        public void addVideo(SayaTubeVideo video)
        {
            stv.Add(video);
        }
        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User : " + this.Username);
            int limit = Math.Min(stv.Count, 8);

            for (int i = 0; i < stv.Count; i++)
            {
                Console.WriteLine($"Video {i + 1}. Judul : {stv[i].title}");
            }
        }
    }
}
