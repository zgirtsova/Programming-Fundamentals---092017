using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Average_Character_Delimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrString = Console.ReadLine().Split(' ').ToArray();
            int sumOfChars = 0;
            int countLetters = 0;

            for (int i = 0; i < arrString.Length; i++)
            {
                for (int j = 0; j < arrString[i].Length; j++)
                {
                    sumOfChars += arrString[i][j];
                    countLetters++;
                }                
            }
            int delimiter = sumOfChars / countLetters;
            string strDelimiter = ((char)delimiter + "").ToUpper();
            Console.WriteLine(string.Join(strDelimiter, arrString));

        }
    }
}
