using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var userLogs = new SortedDictionary<string, 
                SortedDictionary<string, int>>();

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split(' ');
                string ip = input[0];
                string user = input[1];
                int dur = int.Parse(input[2]);

                if (!userLogs.ContainsKey(user)) // new user
                {
                    userLogs.Add(user, new SortedDictionary<string, int>()); 
                    userLogs[user].Add(ip, dur);
                }
                else // existing user
                {
                    if (!userLogs[user].ContainsKey(ip)) // new IP
                    {
                        userLogs[user].Add(ip, dur);
                    }
                    else // existing IP
                    {
                        userLogs[user][ip] += dur;
                    }
                }
            }

            foreach (var user in userLogs)
            {
                int duration = user.Value.Sum(x => x.Value);
                string IPs = string.Join(", ", user.Value.Keys);
                Console.WriteLine($"{user.Key}: {duration} [{IPs}]");
            }
        }
    }
}
