using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[4];
            arr[0] = "0";
            arr[1] = null;
            arr[2] = "2";
            arr[3] = "3";

            string output = "asdf";
            output = output.Remove(output.Length - 1);
            Console.WriteLine(output);
            arr = arr.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            Console.WriteLine(string.Join(" ", arr));
            output = string.Empty;
            Console.Write(output);
            Console.WriteLine("neshto");

        }
    }
}
