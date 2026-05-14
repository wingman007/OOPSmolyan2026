using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSmolyan2026
{
    internal class Athlete : Person
    {
        private string sport;
        public string Sport
        {
            get { return sport; }
            set { sport = value; }
        }

        public Athlete()
        : base("Unknown", 0)
        {
            sport = "Unknown";
        }

        public Athlete(string name, int age, string sport)
        : base(name, age)
        {
            this.sport = sport;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hello, I am an athlete. My name is {name}, I am {age} years old and my sport is {sport}.");
        }
    }
}
