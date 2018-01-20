using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Char_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArr = Console.ReadLine().ToCharArray();
            int[] numArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string result = string.Empty;
            for (int i = 0; i < numArr.Length; i++)
            {
                if (numArr[i] % 2 == 0)
                {
                    result += (char)(charArr[i] - numArr[i]) + "";
                }
                else if (numArr[i] % 2 != 0)
                {
                    result += (char)(charArr[i] + numArr[i]) + "";

                }
            }
            Console.WriteLine(result);
        }
    }
}
