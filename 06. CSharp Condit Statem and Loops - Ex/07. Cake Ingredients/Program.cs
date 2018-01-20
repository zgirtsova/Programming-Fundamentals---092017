using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int counter = 0;

            while (true)
            {
                if (command == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {counter} ingredients.");
                    break;
                }
                else
                {
                    counter++;
                    Console.WriteLine($"Adding ingredient {command}.");
                    command = Console.ReadLine();
                }
            }
        }
    }
}
