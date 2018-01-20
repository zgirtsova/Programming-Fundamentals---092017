using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List < int > list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string word = Console.ReadLine();
            List <string> command = word.Split(' ').ToList();
            bool mustBrake = false;

            while (true)
            {
                switch (command[0])
                {
                    case "Delete": Delete(list, int.Parse(command[1])); break;
                    case "Insert": Insert(list, int.Parse(command[1]), int.Parse(command[2])); break;
                    case "Odd": Odd(list); mustBrake = true; break;
                    case "Even": Even(list); mustBrake = true; break;
                    default:
                        break;
                }
                if (mustBrake)
                {
                    break;
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
        }

        static void Even(List<int> list)
        {
            // Console.WriteLine(string.Join(" ", list.Where(i => list[i] % 2 == 0)));
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    Console.Write(list[i] + " ");
                }
            }
        }
        static void Odd(List<int> list)
        {
            // Console.WriteLine(string.Join(" ", list.Where(i => list[i] % 2 != 0)));
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    Console.Write(list[i] + " ");
                }
            }
        }
        static void Insert(List<int> list, int element, int position)
        {
            list.Insert(position, element);
        }
        static void Delete(List<int> list, int element)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == element)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
