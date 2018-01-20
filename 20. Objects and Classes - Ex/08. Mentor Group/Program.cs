using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _08.Mentor_Group
{
    class Student
    {
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var students = new SortedDictionary<string, Student>();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            AddDates(students);

            AddComments(students);

            PrintOutput(students);
        }

        static void AddDates(SortedDictionary<string, Student> students)
        {
            string lineDates = Console.ReadLine();
            while (lineDates != "end of dates")
            {
                var input = lineDates.Split(new char[] { ' ', ',' });
                string user = input[0];

                if (students.ContainsKey(user))
                {
                    List<DateTime> dates = input.Skip(1).Select(x => DateTime.ParseExact
                    (x, "dd/MM/yyyy", CultureInfo.InvariantCulture)).OrderBy(x => x).ToList();
                    foreach (var d in dates)
                    {
                        students[user].Dates.Add(d);
                    }
                }
                else
                {
                    var st = new Student
                    {
                        Comments = new List<string>(),
                        Dates = new List<DateTime>(),
                    };
                    if (input.Length > 1)
                    {
                        List<DateTime> dates = input.Skip(1).Select(x => DateTime.ParseExact
                        (x, "dd/MM/yyyy", CultureInfo.InvariantCulture)).OrderBy(x => x).ToList();

                        st.Dates = dates;
                    }
                    students.Add(user, st);
                }

                lineDates = Console.ReadLine();
            }
        }

        static void AddComments(SortedDictionary<string, Student> students)
        {
            string lineComments = Console.ReadLine();

            while (lineComments != "end of comments")
            {
                var input = lineComments.Split('-');
                string user = input[0];
                string comment = input[1];

                if (students.ContainsKey(user))
                {
                    students[user].Comments.Add(comment);
                }
                lineComments = Console.ReadLine();
            }
        }

        static void PrintOutput(SortedDictionary<string, Student> students)
        {
            foreach (var st in students)
            {
                Console.WriteLine(st.Key);
                Console.WriteLine("Comments:");
                if (st.Value.Comments.Count != 0)
                {
                    Console.WriteLine(string.Join("\r\n", st.Value.Comments.
                    Select(x => $"- {x}")));
                }
                Console.WriteLine("Dates attended:");
                if (st.Value.Dates.Count != 0)
                {
                    Console.WriteLine(string.Join("\r\n", st.Value.Dates.
                    Select(x => $"-- {x.ToString("dd/MM/yyyy")}")));
                }

            }
        }
    }
}
