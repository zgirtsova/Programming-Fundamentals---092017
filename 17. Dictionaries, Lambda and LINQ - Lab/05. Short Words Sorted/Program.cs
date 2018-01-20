using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {               
            string[] text = Console.ReadLine().ToLower().Split(new char[] {' ', '.', ',',
            ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?'},StringSplitOptions.RemoveEmptyEntries).ToArray();
            text = text.Where(x => x.Length < 5).OrderBy(s => s).Distinct().ToArray();
                        
            Console.WriteLine(string.Join(", ", text));
        }
    }
}
