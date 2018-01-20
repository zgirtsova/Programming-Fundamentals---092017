using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hallName = "";
            double hallPrice = 0;
            double price = 0;
            double discount = 0;
            double pricePerPerson = 0;

            if (people <= 50)
            {
                hallName = "Small Hall";
                hallPrice = 2500;
            }
            else if (people <= 100 && people > 50)
            {
                hallName = "Terrace";
                hallPrice = 5000;
            }
            else if (people > 100 && people <= 120)
            {
                hallName = "Great Hall";
                hallPrice = 7500;
            }
            else
            {
                hallName = "We do not have an appropriate hall.";
            }
            
            switch (package)
            {
                case "Normal":
                    price = 500;
                    discount = 0.05; break;
                case "Gold":
                    price = 750;
                    discount = 0.10; break;
                case "Platinum":
                    price = 1000;
                    discount = 0.15; break;
                default:
                    break;
            }

            pricePerPerson = ((price + hallPrice) * (1 - discount)) / people;

            if (people > 120)
            {
                Console.WriteLine(hallName);
            }
            else
            {
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
        }
    }
}
