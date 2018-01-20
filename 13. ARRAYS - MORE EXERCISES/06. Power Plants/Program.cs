using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Power_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var day = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    nums[i]++; // if plants are alive after season
                }
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] != 0)
                    {
                        nums[j]--;
                    }
                }
                day++;
                var sum = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    sum += nums[j];
                }
                if (sum > 0)
                {
                    if (i == nums.Length - 1)
                    {
                        for (int k = 0; k < nums.Length; k++)
                        {
                            if (nums[k] > 0)
                            {
                                nums[k]++;
                            }
                        }
                        i = -1;
                    }
                    continue;
                }
                else
                {
                    Console.WriteLine("survived {0} days ({1} seasons)", day + 1, day / nums.Length);
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
