using System;

namespace HelloDotNetSession
{
    /*
     DATA TYPES IN C#
     ------------------
     Data types specify the type of data a variable can hold.

     Two categories:
     1. Value Types  → store actual data
     2. Reference Types → store memory address
    */

    internal class Prac_datatypes
    {
        
        // VALUE DATA TYPES


        // 1. Integer types
        public byte By = 120;              // 1 byte (0 to 255)
        public short temp = 32000;         // 2 bytes
        public int value = 435675647;      // 4 bytes
        public long lg = 4356756454000087; // 8 bytes

        // 2. Floating point types
        private float Fl = 3.14F;          // 4 bytes (F required)
        public double Number = 21545566.8258451; // 8 bytes
        public decimal dec = 49763535437.8454365437M; // 16 bytes (M required)

        // 3. Character type
        private char ch = 'A';             // single character

        // 4. Boolean type
        private bool IsValid = true;       // true / false

        
        // REFERENCE DATA TYPES
       

        private string Country = "India is great"; // string is reference type

        // Static reference type
        static string Fname = "Codefist";


        
        // METHOD TO DISPLAY VALUES

        public void ShowData()
        {
            Console.WriteLine("------ VALUE TYPES ------");
            Console.WriteLine("Byte: " + By);
            Console.WriteLine("Short: " + temp);
            Console.WriteLine("Int: " + value);
            Console.WriteLine("Long: " + lg);
            Console.WriteLine("Float: " + Fl);
            Console.WriteLine("Double: " + Number);
            Console.WriteLine("Decimal: " + dec);
            Console.WriteLine("Char: " + ch);
            Console.WriteLine("Bool: " + IsValid);

            Console.WriteLine("\n------ REFERENCE TYPES ------");
            Console.WriteLine("String: " + Country);
            Console.WriteLine("Static String: " + Fname);
        }


        // ===============================
        // TYPE CASTING
        // ===============================

        public void TypeCastingDemo()
        {
            Console.WriteLine("\n------ TYPE CASTING ------");

            // 1. IMPLICIT CASTING (small → big)
            int a = 100;
            long b = a;   // automatic
            Console.WriteLine("Implicit Casting int to long: " + b);

            // 2. EXPLICIT CASTING (big → small)
            double x = 123.45;
            int y = (int)x;  // manual
            Console.WriteLine("Explicit Casting double to int: " + y);

            // 3. STRING TO NUMBER
            string s = "500";
            int num = Convert.ToInt32(s);
            Console.WriteLine("String to Int: " + num);

            // 4. NUMBER TO STRING
            int n = 700;
            string str = n.ToString();
            Console.WriteLine("Int to String: " + str);
        }
    }
}
