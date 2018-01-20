using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sort_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrStr = Console.ReadLine().Split(' ').ToArray();

            while (true)
            {
                bool isSwapped = false;
                for (int i = 0; i < arrStr.Length - 1; i++)
                {
                    if (arrStr[i].CompareTo(arrStr[i + 1]) > 0)
                    {
                        SwapItems(arrStr, i);
                        isSwapped = true;
                    }
                }
                if (!isSwapped)
                {
                    Console.WriteLine(string.Join(" ", arrStr));
                    break;
                }
            }
            
        }

        static void SwapItems(string[] arrStr, int i)
        {
            string temp = arrStr[i];
            arrStr[i] = arrStr[i + 1];
            arrStr[i + 1] = temp;
        }
    }
}
