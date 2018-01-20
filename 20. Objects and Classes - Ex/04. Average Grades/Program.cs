using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade
        {
            get
            {
                return Grades.Average();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                students.Add(ReadStudent());
            }

            Console.WriteLine(string.Join("\r\n", students.Where(x => x.AverageGrade >= 5)
            .OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade)
            .Select(x => x.Name + $" -> {x.AverageGrade:f2}")));
        }

        static Student ReadStudent()
        {
            var input = Console.ReadLine().Split(' ');
            var st = new Student()
            {
                Name = input[0],
                Grades = input.Skip(1).Select(double.Parse).ToList(),               
            };

            return st;          
        }
    }
}
