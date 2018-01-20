using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scanner input = new Scanner(System.in);

            String[] strings = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;

            for (int i = 0; i < strings.Length; i++)
            {
                sum += CalculateString(strings[i]);
            }
            Console.WriteLine($"{sum:F2}");
        }

        static double CalculateString(String s)
        {
            char c1 = ' ';
            char c2 = ' ';
            double sum = 0.0;
            String num = "";
            try
            {
                c1 = s.ElementAt(0);
                c2 = s.ElementAt(s.Length - 1);
                num = s.Substring(1, s.Length - 2);
            }
            catch (Exception)
            {

            }
            double number = double.Parse(num);

            int possition = 0;

            if (Char.IsUpper(c1))
            {
                possition = c1 - 64;
                sum += (number / possition);
            }
            else
            {
                possition = c1 - 96;
                sum += (number * possition);
            }
            if (Char.IsUpper(c2))
            {
                possition = c2 - 64;
                sum -= possition;
            }
            else
            {
                possition = c2 - 96;
                sum += possition;
            }

            return sum;
        }
    }
}
    