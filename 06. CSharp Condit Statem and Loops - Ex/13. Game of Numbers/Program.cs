using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int mun = int.Parse(Console.ReadLine());
            int magicalNum = int.Parse(Console.ReadLine());
            string combination = "";
            int counter = 0;

            for (int i = num; i <= mun; i++)
            {
                for (int j = mun; j >= num; j--)
                {
                    counter++;
                    if (i + j == magicalNum)
                    {
                        combination = i + " + " + j;
                    }
                }
            }

            if (combination != "")
            {
                Console.WriteLine($"Number found! {combination} = {magicalNum}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicalNum}");
            }
        }
    }
}
