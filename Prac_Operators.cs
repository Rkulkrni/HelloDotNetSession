using System;

namespace HelloDotNetSession
{
    /*
     OPERATORS IN C#
     ----------------
     Operators are symbols used to perform operations on variables and values.
    */

    internal class Prac_Operators
    {
        public void ShowOperators()
        {
            Console.WriteLine("========= ARITHMETIC OPERATORS =========");

            int a = 10, b = 5;
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a / b = {a / b}");
            Console.WriteLine($"a % b = {a % b}");

            Console.WriteLine("\n========= RELATIONAL OPERATORS =========");
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"a == b → {a == b}");
            Console.WriteLine($"a != b → {a != b}");
            Console.WriteLine($"a > b  → {a > b}");
            Console.WriteLine($"a < b  → {a < b}");
            Console.WriteLine($"a >= b → {a >= b}");
            Console.WriteLine($"a <= b → {a <= b}");

            Console.WriteLine("\n========= LOGICAL OPERATORS =========");

            bool x = true, y = false;
            Console.WriteLine($"x = {x}, y = {y}");
            Console.WriteLine($"x && y → {x && y}");
            Console.WriteLine($"x || y → {x || y}");
            Console.WriteLine($"!x → {!x}");

            Console.WriteLine("\n========= ASSIGNMENT OPERATORS =========");

            int c = 20;
            Console.WriteLine($"Initial c = {c}");

            c += 5;
            Console.WriteLine($"After c += 5 → {c}");

            c -= 3;
            Console.WriteLine($"After c -= 3 → {c}");

            c *= 2;
            Console.WriteLine($"After c *= 2 → {c}");

            c /= 4;
            Console.WriteLine($"After c /= 4 → {c}");

            c %= 3;
            Console.WriteLine($"After c %= 3 → {c}");

            Console.WriteLine("\n========= INCREMENT / DECREMENT =========");

            int d = 5;
            Console.WriteLine($"Initial d = {d}");
            Console.WriteLine($"d++ → {d++}");
            Console.WriteLine($"Now d = {d}");
            Console.WriteLine($"++d → {++d}");
            Console.WriteLine($"d-- → {d--}");
            Console.WriteLine($"Now d = {d}");
            Console.WriteLine($"--d → {--d}");

            Console.WriteLine("\n========= BITWISE OPERATORS =========");

            int m = 6, n = 3;
            Console.WriteLine($"m = {m}, n = {n}");
            Console.WriteLine($"m & n → {m & n}");
            Console.WriteLine($"m | n → {m | n}");
            Console.WriteLine($"m ^ n → {m ^ n}");
            Console.WriteLine($"~m → {~m}");
            Console.WriteLine($"m << 1 → {m << 1}");
            Console.WriteLine($"m >> 1 → {m >> 1}");

            Console.WriteLine("\n========= TERNARY OPERATOR =========");

            int age = Convert.ToInt32(Console.ReadLine());
            string result = (age >= 18) ? "Adult" : "Minor";
            Console.WriteLine("Age check: " + result);

        }
    }
}
