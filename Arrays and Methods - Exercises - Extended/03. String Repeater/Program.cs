using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatedString(str, num));
        }

        static string RepeatedString(string str, int num)
        {
            string repeatedStr = "";

            for (int i = 0; i < num; i++)
            {
                repeatedStr = repeatedStr + str;
            }
            return repeatedStr;
        }
    }
}
