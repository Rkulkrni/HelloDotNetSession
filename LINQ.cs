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


        /*
         * class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Marks { get; set; }
            public string City { get; set; }
        }

           List<Student> students = new List<Student>
        {
        new Student { Id=1, Name="Amay", Marks=90, City="Pune" },
        new Student { Id=2, Name="Amit", Marks=70, City="Mumbai" },
        new Student { Id=3, Name="Neha", Marks=85, City="Pune" },
        new Student { Id=4, Name="Priya", Marks=60, City="Delhi" },
        new Student { Id=5, Name="Karan", Marks=95, City="Mumbai" }
        };

        1️. Scholarship Selection
        Your company gives scholarships to students scoring above 85 marks.Fetch all eligible students.

        2. Email Campaign
            You need to send emails to all students.
            Extract only student names into a separate list.

        3. Rank List
            Principal wants to display students sorted by highest marks first.
            Show students in descending order of marks.

        4. Fail List
            Students scoring below 70 are failed.
            Get list of failed students.

        5. Training workshop is happening only in Pune.
            Fetch all students from Pune.
         
        6. Topper Search
            Find the single student with highest marks.

        7. Attendance Check
            Check if any student scored full marks (100).
            Return true or false.

        8. Batch Size
            Admin wants to know how many students are from Mumbai.
            Return count only.

        9. Only top 3 performers will attend national competition.
            Get top 3 students based on marks.

        10. Pagination Scenario
            Website shows 2 students per page.
            Skip first 2 students and show remaining students.

        11. City-wise Report
            Management wants students grouped by city.
            Display students city-wise.
         */



    }
}
