using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace OOPSmolyan2026
{
    internal class Person : IIntroducable
    {
        protected string name;
        protected int age;
        private static int counter = 0;
        public const double PI = 3.14;
        public readonly string country;


        //public string GetName() { return name; }
        //public void SetName(string name) { this.name = name; }

        //public int GetAge() { return age; }
        //public void SetAge(int age) { if (age < 120) this.age = age; }

        //public string Name { get; set; }
        //public int Age { get; set; }

        public string Name { 
            get { return name; }
            set { name = value; } 
        }

        public int Age
        {
            get { return age; }
            set { if (value < 120) age = value; }
        }


        public static int Counter
        {
            get { return counter; }
        }

        static Person() {
            counter = 0;
        }

        // Working horse
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            counter++;
            country = "Bulgaria";
        }

        public Person()
        : this("Unknown", 0)
        { }

        public Person(int age, string name)
        : this(name, age)
        {
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name} and I'm {age} years old.");
        }

        public static double NationalIncome()
        {
            return (double)counter * 1000;
        }
    }
}
