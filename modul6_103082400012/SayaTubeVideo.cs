using System;
using System.Collections.Generic;
using System.Text;

namespace modul6_103082400012
{
    public class SayaTubeVideo
    {
        public int id {  get; set; }
        public string title { get; set; }
        public int playCount { get; set; }

        public SayaTubeVideo(string title)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }
        public void IncreasePlayCount(int count)
        {
            this.playCount++;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID           : " + this.id);
            Console.WriteLine("Title        : " + this.title);
            Console.WriteLine("Play Count   : " + this.playCount);
        }
    }
}
