using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = Console.ReadLine();
            var s2 = Console.ReadLine();
            // s1 is the big number and s2 is multiplier - only 1 digit

            var carry = false;
            var carrInt = 0;
            var result = String.Empty;

            for (int i = s1.Length - 1; i >= 0; i--)
            {
                var augend = Convert.ToInt32(s1.Substring(i, 1));
                var addend = int.Parse(s2);
                var multpl = augend * addend;
                multpl += (carry ? carrInt : 0);
                carry = false;
                if (multpl > 9)
                {
                    carry = true;
                    carrInt = multpl / 10;
                    multpl %= 10;
                }

                result = multpl.ToString() + result;
            }

            if (carry)
            {
                result = carrInt.ToString() + result;
            }
            result = result.TrimStart(new char[] { '0' });
            
            Console.WriteLine(result == "" ? "0" : result);
        }
    }
}
