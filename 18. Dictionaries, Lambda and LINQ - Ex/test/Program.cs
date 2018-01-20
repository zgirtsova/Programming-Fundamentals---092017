using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var ipDict = new Dictionary<string, int>();
            ipDict["Zoya"] = 10;
            ipDict["Mimi"] = 20;
            ipDict["Ninu"] = 30;
            ipDict["Popo"] = 40;
            ipDict["Dido"] = 50;

            ipDict["Dido"] += 30;


            ipDict = ipDict.OrderByDescending(pair => pair.Value)
               .ToDictionary(pair => pair.Key, pair => pair.Value);


            Console.WriteLine(string.Join("\r\n", ipDict.
                Select(x => "Name: " + x.Key + " -> Phone: " + x.Value)));

            //Console.WriteLine(phonebook["Zoya"]);
        }
    }
}
