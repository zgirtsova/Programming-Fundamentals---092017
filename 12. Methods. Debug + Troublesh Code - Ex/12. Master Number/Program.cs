using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                if (IsPalindrome(i.ToString()) && SumDiv(i))
                {
                Console.WriteLine(i);
                }
            }
        }
        static bool SumDiv(int n)
        {
            bool evenDigit = false; bool divisible = false;
            int sum = 0;
            while (n != 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0) { evenDigit = true; }
                sum += lastDigit;
                n /= 10;
            }
            if (sum % 7 == 0) { divisible = true; }
            if (evenDigit && divisible) { return true; }
            else { return false; }
        }
        static bool IsPalindrome(string n)
        {
            for (int i = 0; i < n.Length / 2; i++)
            {
                if (n[i] != n[n.Length - 1 - i])
                {
                return false;
                }
            }
            return true;
        }        
    }
}
