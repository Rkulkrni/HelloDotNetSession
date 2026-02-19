using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetSession.OOP_s
{
    internal class Father
    {
        public void FatherMethod()
        {
            Console.WriteLine("Father method");
        }
    }

    internal class Son : Father
    {
        public void SonMethod()
        {
            {
                Console.WriteLine("Son method called");
            }
        }
    }

    // multilevel inheritence

    class University
    {
        public void UniversityMethod()
        {
            Console.WriteLine("Unversity");
        }
    }

    class College : University
    {
        public void CollegeMethod()
        {
            Console.WriteLine("College");
        }
    }

    class Section : College
    {
        public void SectionMethod()
        {
            {
                Console.WriteLine("Section");
            }
        }
    }

    // Heiracheical Inheritence

    class Organisation
    {
        public void OrganisationMethod()
        {
            {
                Console.WriteLine("Organisation method");
            }
        }
    }

    class CEO : Organisation
    {
        public void CEOMethod()
        {
            {
                Console.WriteLine("CEO");
            }
        }

    }

    class CTO : Organisation
    {
        public void CTOMethod()
        {
            Console.WriteLine("CTO");
        }
    }
}


    // Multiple inheritence (Diamond problem)

    //class Mumbai
    //{
    //    public void MumbaiMethod()
    //    {
    //        Console.WriteLine("Mumbai");
    //    }
    //}

    //class Pune
    //{
    //    public void PuneMethod()
    //    {
    //        Console.WriteLine("Pune");
    //    }
    //}

    //class City : Mumbai, Pune
    //{
    //    public void CityMethod()
    //    {
    //        Console.WriteLine("City");
    //    }
    //}

// eg.
//Create a base class Vehicle.
//Base Class:
//Property: Brand
//Method: Start()
//Derived Classes:
//Car
//Bike
//Each derived class should :
//Have its own method (OpenTrunk() for Car, KickStart() for Bike)
// Create objects and call all methods.
//}
