using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetSession
{
    internal class Operators
    {

    // Airthmatic operators
        public void Airthmatic()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine(10 + 10); 
            Console.WriteLine(10 / 2);
            int x = 10;

            Console.WriteLine(x++);

            Console.WriteLine(++x);
            assignment();
        }
    // Assignment operators
        public void assignment()
        {
            int a = 10;

            a += 20; // a= a+20;
            Console.WriteLine(a);

            string abc = "ABC";
            string test = abc ?? "";

            // ternary
            bool isValid = (a == 10) ? true : false; 

        }


    // logical operators
    // Comparasion operators.
    // Relational opeartors

    }
}
