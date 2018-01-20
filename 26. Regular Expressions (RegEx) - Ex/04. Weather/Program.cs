using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string, KeyValuePair<float, string>>();
            var pattern = @"([A-Z]{2})([0-9]{1,2}.[0-9]{1,2})([A-Za-z]+)\|";
            while (input != "end")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    var city = match.Groups[1].Value;
                    var temp = match.Groups[2].Value;
                    var typeOfWeather = match.Groups[3].Value;

                    dict[city] = new KeyValuePair<float, string>(float.Parse(temp), typeOfWeather);                    
                }
                input = Console.ReadLine();
            }
            var sortedDict = dict.OrderBy(x => x.Value.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var d in sortedDict)
            {
                Console.WriteLine($"{d.Key} => {d.Value.Key:f2} => {d.Value.Value}");
            }
        }
    }
}
