using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _04.Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();
            var cashe = new Dictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine().Split(new char[] { ' ', '-', '>', '|' },StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "thetinggoesskrra")
            {
                if (input.Length == 1)
                {
                    string dataSet = input[0];
                    try
                    {
                        dict.Add(dataSet, new Dictionary<string, int>());
                    }
                    catch (Exception)
                    {  }
                    if (cashe.ContainsKey(dataSet))
                    {
                        dict[dataSet] = cashe[dataSet];
                    }
                }
                else
                {
                    string dataKey = input[0];
                    int dataSize = int.Parse(input[1]);
                    string dataSet = input[2];  
                    if (dict.ContainsKey(dataSet))
                    {
                        dict[dataSet].Add(dataKey, dataSize);
                    }
                    else
                    {
                        try
                        {
                            cashe.Add(dataSet, new Dictionary<string, int>());
                            cashe[dataSet].Add(dataKey, dataSize);
                        }
                        catch (Exception)
                        {
                            cashe[dataSet].Add(dataKey, dataSize);
                        }
                    }
                }
                input = Console.ReadLine().Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Dictionary<string, long> summedDataSize = new Dictionary<string, long>();
            BigInteger biggest = 0;
            string biggestDataSet = "";
            foreach (var d in dict.Keys)
            {
                BigInteger summed = dict[d].Sum(x => x.Value);
                if (summed > biggest)
                {
                    biggest = summed;
                    biggestDataSet = d;
                }
            }

            Console.WriteLine($"Data Set: {biggestDataSet}, Total Size: {biggest}");
            foreach (var d in dict[biggestDataSet])
            {
                Console.WriteLine("$." + d.Key);
                
            }
        }
    }
}
