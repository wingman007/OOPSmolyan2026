using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSmolyan2026
{
    internal class Student : Person
    {
        private string facultyNumber;
        public string FacultyNumber { 
            get { return facultyNumber; }
            set { facultyNumber = value; }
        }

        public Student()
        : base("Unknown", 0)
        {
            facultyNumber = "Unknown";
        }

        public Student(string name, int age, string facultyNumber)
        : base(name, age)
        {
            this.facultyNumber = facultyNumber;
        }

        public override void Introduce()
        {
            // base.Introduce();
            Console.WriteLine($"Hello, I am a student. My name is {name}, I am {age} years old and my faculty number is {facultyNumber}.");
        }
    }
}
