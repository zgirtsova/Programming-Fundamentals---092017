using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Arrays___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int num = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(dayOfWeek[num - 1]);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
