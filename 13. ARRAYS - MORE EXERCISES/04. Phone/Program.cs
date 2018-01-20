using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ').ToArray();

            string[] names = Console.ReadLine().Split(' ').ToArray();

            string[] commands = Console.ReadLine().Split(' ').ToArray();

            while (commands[0] != "done")
            {
                if (commands[0] == "call")
                {
                    for (int i = 0; i < phoneNumbers.Length; i++)
                    {
                        if (commands[1] == phoneNumbers[i])
                        {
                            Console.WriteLine($"calling {names[i]}...");
                            string toPrint = GetAnswerForCall(phoneNumbers[i]);
                            Console.WriteLine(toPrint);
                        }
                        else if (commands[1] == names[i])
                        {
                            Console.WriteLine($"calling {phoneNumbers[i]}...");
                            string toPrint = GetAnswerForCall(phoneNumbers[i]);
                            Console.WriteLine(toPrint);
                        }
                    }
                }
                else if (commands[0] == "message")
                {
                    for (int i = 0; i < phoneNumbers.Length; i++)
                    {
                        if (commands[1] == phoneNumbers[i])
                        {
                            Console.WriteLine($"sending sms to {names[i]}...");
                            string toPrint = GetAnswerForMessage(phoneNumbers[i]);
                            Console.WriteLine(toPrint);
                        }
                        else if (commands[1] == names[i])
                        {
                            Console.WriteLine($"sending sms to {phoneNumbers[i]}...");
                            string toPrint = GetAnswerForMessage(phoneNumbers[i]);
                            Console.WriteLine(toPrint);
                        }
                    }
                }
                commands = Console.ReadLine().Split(' ').ToArray();
            }

        }
        public static string GetAnswerForCall(string currentPhoneNumber)
        {
            string result = string.Empty;
            string phoneNumber = string.Empty;
            long sumOfDigits = 0;

            for (int i = 0; i < currentPhoneNumber.Length; i++)
            {
                if (char.IsDigit(currentPhoneNumber[i]))
                {
                    phoneNumber += currentPhoneNumber[i];
                }
            }

            long realPhoneNumber = long.Parse(phoneNumber);

            while (realPhoneNumber > 0)
            {
                sumOfDigits += realPhoneNumber % 10;
                realPhoneNumber /= 10;
            }

            long hours = sumOfDigits / 60;
            long minutes = sumOfDigits % 60;

            if (sumOfDigits % 2 == 0)
            {
                result = $"call ended. duration: {hours:00}:{minutes:00}";
            }
            else
            {
                result = "no answer";
            }

            return result;
        }

        public static string GetAnswerForMessage(string currentPhoneNumber)
        {
            string result = string.Empty;
            string phoneNumber = string.Empty;
            long differenceOfDigits = 0;

            for (int i = 0; i < currentPhoneNumber.Length; i++)
            {
                if (char.IsDigit(currentPhoneNumber[i]))
                {
                    phoneNumber += currentPhoneNumber[i];
                }
            }

            long realPhoneNumber = long.Parse(phoneNumber);

            while (realPhoneNumber > 0)
            {
                differenceOfDigits -= realPhoneNumber % 10;
                realPhoneNumber /= 10;
            }

            if (differenceOfDigits % 2 == 0)
            {
                result = "meet me there";
            }
            else
            {
                result = "busy";
            }

            return result;

        }
                
    }
}
 
 