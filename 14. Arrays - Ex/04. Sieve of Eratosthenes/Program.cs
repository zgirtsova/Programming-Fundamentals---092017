using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()) + 1;
            // слагам + 1, за да може да проверява и последният елемент,
            // който е граничен, т.е. при n = 7 -> 2 3 5 7

            bool[] primes = new bool[n];
            primes = Enumerable.Repeat(true, n).ToArray();
             // setting all values TRUE           
            primes[0] = primes[1] = false;

            for (int i = 0; i < primes.Length; i++)
                {
                if (primes[i] == true)
                    {
                    if (i == 2)
                        {
                         Console.Write(i);
                         for (int p = 2 * i; p < n; p += i)
                            {
                                primes[p] = false;
                            }
                        }
                    else
                        {
                         Console.Write(" " + i);
                         for (int p = 2 * i; p < n; p += i)
                            {
                                primes[p] = false;
                            }
                        }
                    }
                }
            Console.WriteLine();
            
        }
    }
}
