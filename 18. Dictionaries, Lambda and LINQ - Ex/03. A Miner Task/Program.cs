using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dict = new Dictionary<string, int>();

            while (input != "stop")
            {
                string resource = input;
                int qty = int.Parse(Console.ReadLine());
                if (dict.ContainsKey(resource))
                {
                    dict[resource] += qty;
                }
                else
                {
                    dict[resource] = qty;
                }
                input = Console.ReadLine();                
            }
            Console.WriteLine(string.Join("\r\n", dict.
                Select(x => x.Key + " -> " + x.Value)));

        }
    }
}
