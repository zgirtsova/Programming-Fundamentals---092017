using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            string pAttack = "Roundhouse kick"; // every odd turn
            string gAttack = "Thunderous fist"; // every even turn
            int pHealth = 100;
            int gHealth = 100;
            int round = 0;
            // on every third turn both restore 10 health points after the attack is made

            while (true)
            {
                ++round;
                if (round % 2 == 1)
                {
                    gHealth -= peshoDamage;
                    if (gHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {round}th round.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Pesho used {pAttack} and reduced Gosho to {gHealth} health.");
                    }

                }
                else
                {
                    pHealth -= goshoDamage;
                    if (pHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {round}th round.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Gosho used {gAttack} and reduced Pesho to {pHealth} health.");
                    }
                }
                if (round % 3 == 0)
                {
                    pHealth += 10;
                    gHealth += 10;
                }
            }
        }
    }
}
