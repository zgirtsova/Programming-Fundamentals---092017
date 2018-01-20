using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string familyName = "Jonson";
            int age = 27;
            string gender = "f";
            long id = 8306112507;
            long employeeNum = 27563571;
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {familyName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {id}");
            Console.WriteLine($"Unique Employee number: {employeeNum}");
        }
    }
}
