using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Array_and_List_Algorithms___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> path = Console.ReadLine().Split(' ').ToList();
            int energy = int.Parse(Console.ReadLine());
            int position = 0;
            while (true)
            {
                string[] tokens = path[position].Split('|');
                switch (tokens[0])
                {
                    case "Right":
                        position = (position + int.Parse(tokens[1])) % path.Count;
                        break;
                    case "Left":
                        int temp = int.Parse(tokens[1]) - position;
                        position = (temp + int.Parse(tokens[1])) % path.Count;
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
