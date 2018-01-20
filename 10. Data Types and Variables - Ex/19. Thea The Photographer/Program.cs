using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesCount = int.Parse(Console.ReadLine()); // number of pictures
            int filterTimeSecs = int.Parse(Console.ReadLine()); // the time in seconds needed for every pic to be filtered
            int filterFactor = int.Parse(Console.ReadLine()); // in % of total pics that are consider good to give to clients round up
            int uploadTimeSecs = int.Parse(Console.ReadLine()); // the time for every pic to be uploaded    

            long filtertime1 = (long)picturesCount * filterTimeSecs;
            long picsToUploadCount = (long)Math.Ceiling(picturesCount * (filterFactor / 100.0));
            long uploadtime = picsToUploadCount * uploadTimeSecs;

            var totalTime = filtertime1 + uploadtime;

            TimeSpan totalTimeNeededTimeSpan = TimeSpan.FromSeconds(totalTime);

            Console.WriteLine(totalTimeNeededTimeSpan.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
