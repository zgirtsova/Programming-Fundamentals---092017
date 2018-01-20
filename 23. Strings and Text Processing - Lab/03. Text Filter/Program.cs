using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var banned = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            for (int i = 0; i < banned.Length; i++)
            {
                text = text.Replace(banned[i], new string('*', banned[i].Length));
            }
            Console.WriteLine(text);
        }
    }
}
