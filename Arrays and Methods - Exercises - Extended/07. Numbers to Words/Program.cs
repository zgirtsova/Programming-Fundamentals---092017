using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Numbers_to_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int cycle = 0; cycle < n; cycle++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > 999) Console.WriteLine("too large");
                else if (number < -999) Console.WriteLine("too small");
                else if (number < 100 && number > 0 || -100 < number && number < 0) continue;
                else Console.WriteLine(DigitToWord(number));
            }
        }

        static string DigitToWord(int number)
        {
            string result = string.Empty;
            int thirdDigit = Math.Abs(number / 100);
            int secondDigit = Math.Abs((number / 10) % 10);
            int firstDigit = Math.Abs(number % 10);

            if (number < 0) result += "minus ";

            switch (thirdDigit)
            {
                case 1: result += "one-hundred "; break;
                case 2: result += "two-hundred "; break;
                case 3: result += "three-hundred "; break;
                case 4: result += "four-hundred "; break;
                case 5: result += "five-hundred "; break;
                case 6: result += "six-hundred "; break;
                case 7: result += "seven-hundred "; break;
                case 8: result += "eight-hundred "; break;
                case 9: result += "nine-hundred "; break;
            }
            switch (secondDigit)
            {
                case 0: break;
                case 1:
                    switch (firstDigit)
                    {
                        case 0: result += "and ten"; break;
                        case 1: result += "and eleven"; break;
                        case 2: result += "and twelve"; break;
                        case 3: result += "and thirteen"; break;
                        case 4: result += "and fourteen"; break;
                        case 5: result += "and fifteen"; break;
                        case 6: result += "and sixteen"; break;
                        case 7: result += "and seventeen"; break;
                        case 8: result += "and eighteen"; break;
                        case 9: result += "and nineteen"; break;
                    }
                    break;
                case 2: result += "and twenty "; break;
                case 3: result += "and thirty "; break;
                case 4: result += "and forty "; break;
                case 5: result += "and fifty "; break;
                case 6: result += "and sixty "; break;
                case 7: result += "and seventy "; break;
                case 8: result += "and eighty "; break;
                case 9: result += "and ninety "; break;
            }

            if (secondDigit != 1 && firstDigit != 0)
            {
                if (secondDigit == 0)
                {
                    switch (firstDigit)
                    {
                        case 1: result += "and one"; break;
                        case 2: result += "and two"; break;
                        case 3: result += "and three"; break;
                        case 4: result += "and four"; break;
                        case 5: result += "and five"; break;
                        case 6: result += "and six"; break;
                        case 7: result += "and seven"; break;
                        case 8: result += "and eight"; break;
                        case 9: result += "and nine"; break;
                    }
                }
                else
                {
                    switch (firstDigit)
                    {
                        case 1: result += "one"; break;
                        case 2: result += "two"; break;
                        case 3: result += "three"; break;
                        case 4: result += "four"; break;
                        case 5: result += "five"; break;
                        case 6: result += "six"; break;
                        case 7: result += "seven"; break;
                        case 8: result += "eight"; break;
                        case 9: result += "nine"; break;
                    }
                }

            }
            return result;
        }
    }
}
