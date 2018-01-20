using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|');
            var countries = new Dictionary<string, long>();
            var pplDict = new Dictionary<string, Dictionary<string, long>>();
            
            while (input[0] != "report")
            {
                string city = input[0];
                string country = input[1];
                long cityPpl = long.Parse(input[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, cityPpl);
                    pplDict.Add(country, new Dictionary<string, long>());
                    pplDict[country].Add(city, cityPpl);
                }
                else
                {
                    countries[country] += cityPpl;
                    pplDict[country].Add(city, cityPpl);
                }
                input = Console.ReadLine().Split('|');

            }

            countries = countries.OrderByDescending(pair => pair.Value)
            .ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var ctr in countries.Keys)
            {
                pplDict[ctr] = pplDict[ctr].OrderByDescending(pair => pair.Value)
                .ToDictionary(pair => pair.Key, pair => pair.Value);
            }

            foreach (var ctr in countries)
            {
                Console.WriteLine($"{ctr.Key} (total population: {countries[ctr.Key]})");
                foreach (var city in pplDict[ctr.Key])
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
