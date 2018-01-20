using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var legend = new Dictionary<string, string>();
            legend["shards"] = "Shadowmourne";
            legend["fragments"] = "Valanyr";
            legend["motes"] = "Dragonwrath";
            var keyMat = new Dictionary<string, int>();
            keyMat["shards"] = 0;
            keyMat["fragments"] = 0;
            keyMat["motes"] = 0;
            var junk = new SortedDictionary<string, int>();

            var input = Console.ReadLine().ToLower().Split(' ');

            while (true)
            {
                for (int i = 0; i < input.Length - 1; i += 2)
                {                  
                    string material = input[i + 1];
                    int qty = int.Parse(input[i]);
                    if (legend.ContainsKey(material)) //checks if material is legendary
                    {                        
                        keyMat[material] += qty;

                        keyMat = keyMat.OrderByDescending(pair => pair.Value)
                        .ThenBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
                        // ordering dictionarie by value, descending

                        string biggest = keyMat.Keys.First();
                        if (keyMat[biggest] >= 250)
                        {
                            Console.WriteLine($"{legend[biggest]} obtained!");
                            keyMat[biggest] -= 250;

                            keyMat = keyMat.OrderByDescending(pair => pair.Value)
                            .ThenBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
                            // ordering dictionarie by value, descending

                            foreach (var mat in keyMat)
                            {
                                Console.WriteLine($"{mat.Key}: {mat.Value}");
                            }
                            foreach (var mat in junk)
                            {
                                Console.WriteLine($"{mat.Key}: {mat.Value}");
                            }
                            return;
                        }
                    }
                    else // non legendary material
                    {
                        if (!junk.ContainsKey(material)) //new junk material
                        {
                            junk[material] = qty;
                        }
                        else // existing junk material
                        {
                            junk[material] += qty;
                        }
                    }
                }
                input = Console.ReadLine().ToLower().Split(' ');
            }
        }
    }
}
