using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.String_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < n; i++)
            {
                char letter = (char)Console.Read();
                string resultFromChar = EncryptStart(letter) + EncryptMiddle(letter)
                    + EncryptEnd(letter);
                result += resultFromChar;
                Console.ReadLine();
            }
            Console.WriteLine(result);

        }

        static string EncryptEnd(char letter)
        {
            int asciiLetter = (int)letter;
            while (asciiLetter > 9)
            {
                asciiLetter /= 10;
            }

            string result = "" + (char)((int)letter - asciiLetter);
            return result;
        }
        static string EncryptStart(char letter)
        {
            string result = "" + (char)((int)letter + (int)letter % 10);
            return result;
        }
        static string EncryptMiddle(char letter)
        {
            string result = "";
            int asciiLetter = (int)letter;
            int middleNums = 0;

            while (asciiLetter > 0)
            {
                middleNums = asciiLetter % 10;
                asciiLetter /= 10;
            }
            middleNums = middleNums * 10 + (int)letter % 10;
            result = middleNums + "";
            return result;
        }
    }
}
