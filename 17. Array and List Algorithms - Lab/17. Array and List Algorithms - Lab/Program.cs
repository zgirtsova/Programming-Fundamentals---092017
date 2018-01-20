using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Array_and_List_Algorithms___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var element = int.Parse(Console.ReadLine());

            var containsElement = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    containsElement = true; break;
                }
            }

                if (containsElement)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            
        }
    }
}
