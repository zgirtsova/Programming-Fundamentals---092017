using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listInt = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int temporaryItem = 0;
            for (int i = 1; i < listInt.Count / 2; i++)
            {
                temporaryItem = listInt[i];
                listInt[i] = listInt[listInt.Count - i - 1];
                listInt[listInt.Count - i - 1] = temporaryItem;
            }
            Console.WriteLine(string.Join(" ", listInt));
        }
    }
}
