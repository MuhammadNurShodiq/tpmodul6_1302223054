using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302223054
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            this.id = RandomID();
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("=== Video ===");
            Console.WriteLine($"ID: {id}, \nTitle: {title}, \nPlay Count: {playCount} \n");
        }

        private int RandomID()
        {
            Random random = new Random();
            return random.Next(10000, 99999);
        }
    }
}
