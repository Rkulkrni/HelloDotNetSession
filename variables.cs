using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetSession
{
    internal class Variables
    {
        public Byte By = 100;
        public short temp = 32767;
        public int value = 435675647;
        public long lg = 4356756454000087667;
        private float Fl = 3.14F;
        public double Number = 2154556682584510;
        public decimal dec = 49763535437.8454365437M;
        private string Country = "India is great";
        private bool IsValid = true;
        private char ch = 'A';

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
    }
}
