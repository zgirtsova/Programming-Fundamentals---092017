using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] textOne = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] textTwo = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            bool areDifferent = false;

            for (int i = 0; i < Math.Min(textOne.Length, textTwo.Length); i++)
            {
                try
                {
                    if (textOne[i] != textTwo[i])
                    {
                        areDifferent = true;
                        if (textOne[i] < textTwo[i])
                        {
                            Console.WriteLine(string.Join("", textOne));
                            Console.WriteLine(string.Join("", textTwo));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(string.Join("", textTwo));
                            Console.WriteLine(string.Join("", textOne));
                            break;
                        }
                    }
                }
                catch { break; }
            }
            if (!areDifferent)
            {
                if (textOne.Length < textTwo.Length)
                {
                    Console.WriteLine(string.Join("", textOne));
                    Console.WriteLine(string.Join("", textTwo));
                }
                else
                {
                    Console.WriteLine(string.Join("", textTwo));
                    Console.WriteLine(string.Join("", textOne));
                }
            }
        }
    }
}
