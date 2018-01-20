using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = Console.ReadLine();
            var s2 = Console.ReadLine();
            var smaller = "";
            var bigger = "";
            if (s1.Length != s2.Length)
            {
                smaller = (s1.Length < s2.Length) ? s1 : s2;
                bigger = (s1.Length > s2.Length) ? s1 : s2;
                smaller = FillWithZeros(smaller, bigger);
            }
            else
            {
                smaller = s1;
                bigger = s2;
            }
            

            var carry = false;
            var result = String.Empty;

            for (int i = smaller.Length - 1; i >= 0; i--)
            {
                var augend = Convert.ToInt32(smaller.Substring(i, 1));
                var addend = Convert.ToInt32(bigger.Substring(i, 1));
                var sum = augend + addend;
                sum += (carry ? 1 : 0);
                carry = false;
                if (sum > 9)
                {
                    carry = true;
                    sum -= 10;
                }

                result = sum.ToString() + result;
            }

            if (carry)
            {
                result = "1" + result;
            }

            // result.TrimStart(new char[] { '0' });
            Console.WriteLine(result.TrimStart(new char[] { '0' }));
        }

        static string FillWithZeros(string smaller, string bigger)
        {
            var output = smaller.PadLeft(bigger.Length, '0');
            return output;
        }
    }
}
