using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public IList<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public string GroupName { get; set; }

        public Student(string firstName, string lastName, int age, string facultyNumber, string phone, string email, IList<int> marks, int groupNumber, string groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.GroupName = groupName;


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var student = new List<Student>
        {
            new Student("Ivan", "Ivanov",18,"100014","021234","",new List<int> {5, 3, 5, 6},1,"Fundamentals"),
            new Student("Pesho", "Peshev",18,"200015","+3592321638","peshev@abv.bg",new List<int> {5, 2, 5, 6},1,"Fundamentals"),
            new Student("Petko", "Petkov",19,"300014","07113","petkov@abv.bg",new List<int> {5, 2, 5, 6},2, "Front-End Development"),
            new Student("Goshko", "Goskov",19,"400014","083545","goshov@gmail.com",new List<int> {5, 2, 2, 5},2,"Front-End Development"),
            new Student("Mariika", "Marieva",20,"500014","+359 2 554135435","niama@ght.gh",new List<int> {6, 2, 6, 4},1,"Fundamentals"),
            new Student("Rositza", "Roseva",21,"600013","112345","pakmail@abv.bg",new List<int> {4, 2, 2, 3},2,"Front-End Development"),
            new Student("Ivan", "Petkov",36,"700013","524354","zashto@hotmail.com",new List<int> {6, 2, 6, 6},3,"Back-End Development"),
        };


            var tudentsByGroups =
                from st in student
                group st by st.GroupName;


            foreach (var studentGroupName in tudentsByGroups)
            {
                Console.WriteLine("Group Name: {0}, Number of Students: {1}", studentGroupName.Key, studentGroupName.Count());
                foreach (var st in studentGroupName)
                {
                    Console.WriteLine("{0} {1}", st.FirstName, st.LastName);
                }
                Console.WriteLine("-------------");
            }


        }


    }
}
