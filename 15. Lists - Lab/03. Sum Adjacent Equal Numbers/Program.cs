using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> listOfNums = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            int index = 0;
           
            while (index < listOfNums.Count - 1)
            {
                if (listOfNums[index] == listOfNums[index + 1])
                {
                    listOfNums[index] *= 2;
                    listOfNums.RemoveAt(index + 1);
                    if (index > 0)
                    {
                        index--;
                    }
                }
                else
                {
                    index++;
                }
            }                     
            
            Console.WriteLine(string.Join(" ",listOfNums));
        }
    }
}
