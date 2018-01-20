using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string locomotive = @"^(\<\[[^ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789]*\]\.)(\.\[[ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789]*\]\.)+$";
            string locoOnly = @"^(\<\[[^ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789]*\]\.)$";
            Regex locoRegEx = new Regex(locomotive);
            Regex LocoOnlyRegEx = new Regex(locoOnly);

            while (inputLine != "Traincode!")
            {
                bool containsLocoAndWagons = locoRegEx.IsMatch(inputLine);
                bool containsLocoOnly = LocoOnlyRegEx.IsMatch(inputLine);
                if (containsLocoAndWagons || containsLocoOnly)
                {
                    Console.WriteLine(inputLine);
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
