﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            // regex patterns
            string pattern = @"([^&=?\s]*)=([^&=\s]*)";
            Regex pairs = new Regex(pattern);
            string regex = @"((%20|\+)+)";

            // input and matching
            string inputLine;

            while (!((inputLine = Console.ReadLine()) == "END"))
            {
                MatchCollection matches = pairs.Matches(inputLine);

                // storing matching fields and values into a dictionary, per line of input
                Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();
                for (int i = 0; i < matches.Count; i++)
                {
                    string field = matches[i].Groups[1].Value;
                    field = Regex.Replace(field, regex, word => " ").Trim();

                    string value = matches[i].Groups[2].Value;
                    value = Regex.Replace(value, regex, word => " ").Trim();

                    if (!results.ContainsKey(field))
                    {
                        List<string> values = new List<string>();
                        values.Add(value);
                        results.Add(field, values);
                    }
                    else if (results.ContainsKey(field))
                    {
                        results[field].Add(value);
                    }
                }

                // printing
                foreach (var pair in results)
                {
                    Console.Write("{0}=[{1}]", pair.Key, string.Join(", ", pair.Value));
                }
                Console.WriteLine();
            }
        }
    }
}
