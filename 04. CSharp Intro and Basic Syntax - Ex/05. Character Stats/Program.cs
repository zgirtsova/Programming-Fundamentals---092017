using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxtHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            string health = new string('|', currentHealth);
            string health2 = new string('.', maxtHealth - currentHealth);
            string energy = new string('|', currentEnergy);
            string energy2 = new string('.', maxEnergy - currentEnergy);


            Console.WriteLine($"Name: {name}\n" +
                $"Health: |{health}{health2}|\n" +
                $"Energy: |{energy}{energy2}|");
        }
    }
}
