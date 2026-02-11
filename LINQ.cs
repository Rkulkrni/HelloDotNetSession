using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetSession
{
    internal class LINQ
    {
        public void getLINQOperator()
        {
            List<int> numbers = new List<int> { 5, 15, 10, 20, 25 };

            // where : 
            var result = numbers.Where(x => x > 10);

            foreach (var item in result)
            {
                //Console.WriteLine(item);
            }

            // Select
            var a = numbers.Select(x => x * 10);
            foreach (var item in a)
            {
                //Console.WriteLine(item);
            }

            // OrderBy() → Sort ascending
            var sorted = numbers.OrderByDescending(x => x);
            //var sorted = numbers.OrderBy(x => x);
            foreach (var item in sorted)
            {
                //Console.WriteLine(item);
            }

            // 4) FirstOrDefault() :Safe version (no crash if empty)
            var value = numbers.FirstOrDefault(x => x > 20);
            //Console.WriteLine(value);
            //Use in real projects

            //5) Count() → Total items
            //Console.WriteLine(numbers.Count());

            //6) Sum()
            //Console.WriteLine(numbers.Sum());

            //Any() → Check exists : 
            //Console.WriteLine(numbers.Any(x => x > 50));

            //8) Take() → first N items
            var firstTwo = numbers.Take(3);


            foreach (var item in firstTwo)
            {
                //Console.WriteLine(item);
            }

            //9) Skip() → skip first N
            var rest = numbers.Skip(2);
            foreach (var item in rest)
            {
                //Console.WriteLine(item);
            }
            //✔ Used in pagination

            //10) GroupBy() → grouping(✔ Very important in projects)
            var groups = numbers.GroupBy(x => x % 2);

            foreach (var g in groups)
            {
                Console.WriteLine("Group: " + g.Key);

                foreach (var item in g)
                    Console.WriteLine(item);
            }

        }

    }
}
