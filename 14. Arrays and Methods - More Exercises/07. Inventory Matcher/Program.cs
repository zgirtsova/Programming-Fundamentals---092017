using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodsList = Console.ReadLine().Split(' ').ToList();
            var quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            var command = Console.ReadLine();
            while (command != "done")
            {
                int indexOfGoods = goodsList.IndexOf(command);
                Console.WriteLine(
                    $"{goodsList[indexOfGoods]} costs: {prices[indexOfGoods]}; Available quantity: {quantities[indexOfGoods]}"
                    );
                command = Console.ReadLine();
            }
        }
    }
}
