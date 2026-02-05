using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HelloDotNetSession
{
    internal class Conditions
    {
        // If condition.
        public void Check()
        {
            int Marks = 88;
            if (Marks == 35) {
                Console.WriteLine("You are pass!");
            } else if (Marks > 50 && Marks < 80)
            {
                Console.WriteLine("You r pass with grade B");
            } else if (Marks > 80)
            {
                Console.WriteLine("You have received Grade A");
            } else
            {
                Console.WriteLine("Your are fail!");
            }
        }

        // Switch condition
        public void Switch()
        {
            Console.WriteLine("Enter your score : ");
            int Marks = Convert.ToInt32(Console.ReadLine());
            switch(Marks)
            {
                case 35:
                    Console.WriteLine("Your are pass");
                    break;

                case 50: Console.WriteLine("You r pass with grade B");
                    break;

                case 80: Console.WriteLine("You have received Grade A");
                    break;

                default
                    : Console.WriteLine("Your are fail!");
                    break;
            }
        }

        // While Loop
        public void getWhileLoop()
        {
            int[] numbers =  { 10, 20, 40, 22, 44 };
            int Target = 41;
            int Index = 0;
            bool Found = false;
            while (numbers.Length > Index)
            {
                if (numbers[Index] == Target)
                {
                    Console.WriteLine($"Found {Target} at index {Index}.");
                    Found = true;
                    break;
                }
                Index++;
            }
            if (!Found)
            {
                Console.WriteLine("Target not found");
            }
        }

        // Do loop 
        public void DoWhileLoop()
        {
            int Number;
            do
            {
                Console.WriteLine("Enter positive number :");
                Number = Convert.ToInt32(Console.ReadLine());
            } while (Number < 0);
            {
                Console.WriteLine($"You entered: {Number}");
            }
        }
    }
}
