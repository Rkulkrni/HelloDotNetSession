using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetSession
{
    internal class Prac_conditions
    {
        int marks = 60;

        // ================= IF =================
        public void ifDemo()
        {
            Console.WriteLine("------ IF CONDITION ------");
            Console.WriteLine($"Marks = {marks}");

            if (marks >= 35)
            {
                Console.WriteLine("Student Passed");
            }
        }

        // ================= IF ELSE =================

        public void ifElseDemo()
        {
            Console.WriteLine("\n------ IF ELSE ------");

            if (marks >= 35)
            {
                Console.WriteLine("Student Passed");
            }
            else
            {
                Console.WriteLine("Student Failed");
            }
        }

        // ================= IF ELSE IF =================

        public void ifElseIFDemo()
        {
            if (marks >= 75)
            {
                Console.WriteLine("Grade A ");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade B ");
            }
            else if (marks >= 35)
            {
                Console.WriteLine("Grade C ");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

        // ================= SWITCH =================

        public void SwitchDemo()
        {
            Console.WriteLine("\n------ SWITCH CASE ------");
            int grade = marks / 10; // Convert marks to level

            switch (grade)
            {
                case 10:
                case 9:
                case 8:
                    Console.WriteLine("Excellent");
                    break;

                case 7:
                case 6:
                    Console.WriteLine("Good");
                    break;

                case 5:
                case 4:
                    Console.WriteLine("Average");
                    break;
                default:
                    Console.WriteLine("Fail");
                    break;

            }
        }

        // ================= WHILE LOOP =================

        public void WhileDemo()
        {
            Console.WriteLine("\n------ WHILE LOOP ------");
            int m = marks;
            while(m <= 70)
            {
                Console.WriteLine("Marks value: " + m);
                m += 5;
            }
        }

        // ================= DO WHILE LOOP =================

        public void DoWhileDemo()
        {
            Console.WriteLine("\n------ DO WHILE LOOP ------");
            int m = marks;

            do
            {
                Console.WriteLine("Marks value: " + m);
                m += 5;
            } while (m <= 70);
        }

        // ================= FOR LOOP =================

        public void ForLoopDemo()
        {
            int n = 100;
            for(int i = 1; i <= n; i++)
            {
                if(i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
