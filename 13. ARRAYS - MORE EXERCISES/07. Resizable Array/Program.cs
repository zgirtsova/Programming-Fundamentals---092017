using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Resizable_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int?[] arr = new int?[4];
            string[] commands = Console.ReadLine().Split().ToArray();
            int counterIndex = -1;
            int lastNumOfArr = 0;

            while (commands[0] != "end")
            {
                counterIndex++; // следи ми итерациите на i, поредия индекс на масива

                if (counterIndex == arr.Length)
                {
                    int?[] twinArr = new int?[arr.Length];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        twinArr[i] = arr[i];
                    }
                    arr = new int?[arr.Length * 2];
                    for (int i = 0; i < twinArr.Length; i++)
                    {
                        arr[i] = twinArr[i];
                    }
                }

                if (commands[0] == "push")
                {
                    arr[counterIndex] = int.Parse(commands[1]);
                    lastNumOfArr = counterIndex; // remembers last num index of an arr

                }
                else if (commands[0] == "pop")
                {
                    arr[lastNumOfArr] = null;
                }
                else if (commands[0] == "removeAt")
                {
                    int removeIndex = int.Parse(commands[1]); //sets the specified index to null according to the input given
                    int counterHasValue = -1;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (counterHasValue == removeIndex)
                        {
                            removeIndex = i - 1; // sets the real position in my arr of the index that should be removed
                            break;
                        }
                        else if (arr[i] != null)
                        {
                            counterHasValue++;
                        }

                    }

                    arr[removeIndex] = null; //sets the real index to null
                }
                else if (commands[0] == "clear")
                {
                    arr = new int?[4];
                    counterIndex = -1;

                }

                commands = Console.ReadLine().Split().ToArray();
            }

            string output = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    output += arr[i] + " ";
                }                
            }
            if (output == string.Empty)
            {
                Console.WriteLine("empty array");
                return;
            }
            else
            {
                output = output.Remove(output.Length - 1);

            }
            Console.WriteLine(output);
            
        }        
    }
}
