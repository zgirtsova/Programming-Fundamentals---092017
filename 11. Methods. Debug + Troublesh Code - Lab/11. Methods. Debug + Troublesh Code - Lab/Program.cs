using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Methods.Debug___Troublesh_Code___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            printReceiptHeader();
            printReceiptBody();
            printReceiptFooter();
        }

        private static void printReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
        private static void printReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        private static void printReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
    }
}
