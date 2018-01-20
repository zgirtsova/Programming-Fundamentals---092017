using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                String result = Console.ReadLine();
                if (result == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    ShowSuccess(operation, message);
                }
                else if (result == "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    ShowError(operation, code);
                }
            }
          
        }

        static void ShowError(string operation, int code)
        {
            string reason = "";
            if (code >= 0)
            {
                reason = "Invalid Client Data";
            }
            else { reason = "Internal System Failure";  }
            Console.WriteLine($"Error: Failed to execute { operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            Console.WriteLine($"Reason: {reason}.");
        }
        static void ShowSuccess(string operation, string message)
        {
            Console.WriteLine("Successfully executed {0}.", operation);
            Console.WriteLine("==============================");
            Console.WriteLine("Message: {0}.", message);
        }
    }
}
