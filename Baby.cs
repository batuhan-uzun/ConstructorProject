using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorProject
{
    internal class Baby
    {
        public Baby() // Default Constructor with no parameters
        {
            BirthDate = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }

        public Baby(string name, string surname) // Alternative Constructor that takes parameters
        {
            Name = name;
            Surname = surname;
            BirthDate = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }

        public DateTime BirthDate { get; set; } // We get set the Birth Date, Name and Last Name properties
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
