using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetSession.OOP_s
{
    internal class Country
    {
        private string Name { get; set; }
        private int CountryCode { get; set; }
        private string Continont { get; set; }

        // Parametered Constructor 
        public Country(string Nm, int CC)  // Constructor.
        { 
            Name = Nm;
            CountryCode = CC;
            Console.WriteLine($"{Nm} and {CC}");
        }

        // without paramter
        public Country()  // Constructor.
        {
            Name = "USA";
            CountryCode = 01;
            Console.WriteLine($"{Name} and {CountryCode}");
        }

        // Constructor copying.

        public Country(Country other, string continont)
        {
            Name = other.Name;
            CountryCode = other.CountryCode;
            Continont = continont;

            Console.WriteLine($"Name : {Name} and CountryCode : {CountryCode} and Continont: {Continont}");
        }
    }
}
