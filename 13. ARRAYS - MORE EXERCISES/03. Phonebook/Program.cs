using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split().ToArray();
            string[] contactsNames = Console.ReadLine().Split().ToArray();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "done")
                {
                    return;
                }
                else
                {
                    for (int i = 0; i < contactsNames.Length; i++)
                    {
                        if (command == contactsNames[i])
                        {
                            Console.WriteLine($"{contactsNames[i]} -> {phoneNumbers[i]}");
                            break;
                        }
                    }
                }
            }
        }
    }
}
