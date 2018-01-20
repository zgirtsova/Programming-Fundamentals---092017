using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine());

            int[] arrOfElements = new int[numberOfElements];
            int sum = 0;

            for (int i = 0; i < arrOfElements.Length; i++)
            {
                arrOfElements[i] = int.Parse(Console.ReadLine());
                sum += arrOfElements[i];
            }
            Console.WriteLine(sum);
        }
    }
}
