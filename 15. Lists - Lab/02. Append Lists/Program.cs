using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfTokens = Console.ReadLine().Split('|').ToList();
            for (int i = listOfTokens.Count - 1; i >= 0; i--)
            {
                string[] arr = listOfTokens[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                listOfTokens[i] = string.Join(" ",arr);
            }
            listOfTokens.Reverse();
            Console.WriteLine(string.Join(" ",listOfTokens));
        }
    }
}
