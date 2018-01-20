using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine(max);
                    break;

                case "char":
                char firstt = char.Parse(Console.ReadLine());
                char secondd = char.Parse(Console.ReadLine());
                char maxx = GetMax(firstt, secondd);
                Console.WriteLine(maxx);
                    break;

                case "string":
                string firsttt = Console.ReadLine();
                string seconddd = Console.ReadLine();
                string maxxx = GetMax(firsttt, seconddd);
                Console.WriteLine(maxxx);
                    break;
            }
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
