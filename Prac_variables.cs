using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HelloDotNetSession
{


    //  1.   Local Variable :-

    //A variable defined within a block or method or constructor is called local variable.

    // 1. These variables are created when the block is entered or the function is called and destroyed after exiting from the block or when the call returns from the function.
    // 2. The scope of these variables exists only within the block in which the variable is declared.i.e.we can access these variables only within that block.

    class StudentDetails
    {

        // Method
        public void StudentAge()
        {
            // local variable age
            int age = 0;
            age = age + 10;
            Console.WriteLine("Local----------------------------------");
            Console.WriteLine("Student age is : " + age);
        }

    }



    //  2.  Instance Variables or Non - Static Variables

    // 1. Instance variables in C# are non-static variables declared inside a class but outside methods or constructors. 
    // 2. They are created when an object is instantiated and destroyed when the object is destroyed and can have access specifiers.

    class Marks
    {

        // These variables are instance variables. These variables are in a class and are not inside any function

        public int engMarks;
        public int mathsMarks;
        public int phyMarks;
    }



    //  3.  Static Variables or Class Variables

    // 1. Static variables in C# are class-level variables declared with the static keyword inside a class but outside methods or constructors. 
    // 2. Only one copy exists per class, shared by all objects and they are created at program start and destroyed when execution ends.

    // Note:- To access static variables, there is no need to create any object of that class, simply access the variable as: class_name.variable_name;

    class Emp
    {

        // static variable salary
        public static double salary;
        public static string name = "Ramesh";
    }


    //    Difference between Instance variable & Static variable

    //Each object has its own copy of instance variables, whereas only one copy of a static variable exists per class, shared by all objects.
    //Changes in an instance variable affect only that object, while changes in a static variable are reflected across all objects.
    //Instance variables are accessed through object references, whereas static variables can be accessed directly using the class name.
    //Instance variables are initialized every time an object is created(n times for n objects), while a static variable is initialized only once in the class lifecycle.

    //The Syntax for static and instance variables are :

    class Example
    {
        static int a; // static variable
        int b;        // instance variable
    }



    // 4.  Constants Variables

    // If a variable is declared by using the keyword "const" then it as a constant variable
    // and these constant variables can't be modified once after their declaration, so it's must initialize at the time of declaration only.

    class Program
    {

        // constant variable max but no value is provided
        //const float max;

        //prog.cs(8,17): error CS0145: A const field requires a value to be provided

        // instance variable
        public int a = 10;

        // static variable
        public static int b = 20;

        // constant variable
        public const float max = 50;
    }

    //  Important Points about Constant Variables:  

    // 1. The behavior of constant variables will be similar to the behavior of static variables i.e.initialized one and only one time in the life cycle of a class
    //    and doesn't require the instance of the class for accessing or initializing.
    // 2. The difference between a static and constant variable is, static variables can be modified whereas constant variables can't be modified once it declared.


    //  5. Read-Only Variables

    //  1. A readonly variable in C# is a variable whose value can only be assigned at the time of declaration or within a constructor of the same class and once assigned,
    //     it cannot be modified for the lifetime of the object.

    class ReadonlyVar
    {

        // instance variable
        public int a = 80;

        // static variable
        public static int b = 40;

        // Constant variables
        public const float max = 50;

        // readonly variables
        public readonly int k = 100;

        // readonly variables
        readonly string country;

        public ReadonlyVar(string t)
        {
            country = t;
            Console.WriteLine(country);
        }
    }
}