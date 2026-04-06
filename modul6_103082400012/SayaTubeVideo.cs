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
            if (title == null)
            {
                throw new ArgumentNullException("Judul tidak boleh kosong");
            }
            else if (title.Length > 200)
            {
                throw new ArgumentException("Maksimal panjang judul 200 karakter");
            }

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }
        public void IncreasePlayCount(int count)
        {
            if (count > 25000000)
            {
                throw new ArgumentException("Jumlah penambahan play count tidak boleh lebih dari 25.000.000");
            }
            else if (count < 0)
            {
                throw new ArgumentException("Jumlah penambahan play count tidak boleh negatif");
            }
            try
            {
                checked
                {
                    this.playCount++;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID           : " + this.id);
            Console.WriteLine("Title        : " + this.title);
            Console.WriteLine("Play Count   : " + this.playCount);
        }
    }
}
