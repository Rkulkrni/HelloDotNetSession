using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetSession
{
    internal class Variables
    {
        readonly string country;
        public Variables(string c) 
        {
            country = c;
            Console.WriteLine(country);
            Console.ReadLine();
        }
        public Byte By = 100;
        public short temp = 32767;
        public int value = 435675647;
        public long lg = 4356756454000087667;
        private float Fl = 3.14F;
        public double Number = 215455668258451;
        public decimal dec = 49763535437.8454365437M;
        private string Country = "India is great";
        private bool IsValid = true;
        private char ch = 'A';
        static string Fname = "Codefist";
        //char → int → long → float → double
        static char Text = 'A';
        static int ascii = Text;   // char → int (ASCII value 65)

        static long lon = ascii;

        static string s = "100";
        static int n = int.Parse(s);

        public string Str = n.ToString();
        public void Execute()
        {
            if (Str !=null)
            {
                Console.WriteLine(Str);
            }

        }

        // Variables : Container.
        // local scole varaible
        public void Execution() 
        {
            const int A = 10;
        }

        // instance variable ; 

        // Static varibale

        // const varaible

        // readonly variable
    }


}
