﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            List<int> temp = new List<int>();
            List<int> result = new List<int>();
            
            temp.Add(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > input[i - 1])
                {
                    temp.Add(input[i]);
                    if (i == input.Length - 1)
                    {
                        Console.WriteLine(string.Join(" ", temp));
                        if (temp.Count > result.Count)
                        {
                            result.Clear();
                            result.InsertRange(0, temp);
                        }
                    }
                }
                else
                {
                    Console.WriteLine(string.Join(" ", temp));
                    if (temp.Count > result.Count)
                    {
                        result.Clear();
                        result.InsertRange(0, temp);
                    }
                    temp.Clear();
                    temp.Add(input[i]);
                    if (i == input.Length - 1)
                    {
                        Console.WriteLine(string.Join(" ", temp));
                    }

                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
