using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' '); 
            var userDict = new SortedDictionary<string, Dictionary<string, int>>();
            // keeps usernames as keys and for every user - list of strings with user's IPs
            //var ipDict = new Dictionary<string, int>();
            //// keeps all the IPs as keys and theit occurencies as values
                                
            while (input[0] != "end")
            {
                string user = input[2].Substring(5);
                string IP = input[0].Substring(3);

                if (!userDict.ContainsKey(user)) //new USER
                {
                    userDict.Add(user, new Dictionary <string, int>());
                    userDict[user].Add(IP, 1);
                }
                else // existing user : 2 cases
                {
                    if (userDict[user].ContainsKey(IP)) //existing USER,existing IP
                    {
                        userDict[user][IP] += 1;
                    }
                    else //existing USER, new IP
                    {
                    userDict[user].Add(IP, 1);
                    }
                }

                input = Console.ReadLine().Split(' ');
            }
            foreach (var user in userDict) 
            {
                string ipAdress = "";
                List<string> ipRow = new List<string>();

                foreach (var listVal in userDict[user.Key].Keys)
                {
                    ipAdress = listVal + " => " + userDict[user.Key][listVal];
                    ipRow.Add(ipAdress);
                }
                ipAdress = string.Join(", ",ipRow);
                Console.WriteLine(user.Key + ":");
                Console.WriteLine(ipAdress + ".");
            }
        }
    }
}
