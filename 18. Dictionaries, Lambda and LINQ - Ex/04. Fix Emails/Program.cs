using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var mailList = new Dictionary<string, string>();
            string input = Console.ReadLine();

            while (input != "stop")
            {
                string name = input;
                string mail = Console.ReadLine();

                if (!(mail.EndsWith("us") || mail.EndsWith("uk")))
                {
                    mailList[name] = mail;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join("\r\n", mailList.
                Select(x => x.Key + " -> " + x.Value)));

        }
    }
}
