//   LINQ = Language Integrated Query → used to filter, sort, search, group collections like List.



using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetSession
{
    internal class Prac_LINQ
    {

        class Order
        {
            public int OrderId { get; set; }
            public string? Customer { get; set; } 
            public string? City { get; set; }
            public double Amount { get; set; }
            public bool IsDelivered { get; set; }
        }

        List<Order> orders = new List<Order>
{
        new Order{ OrderId=1, Customer="Ramesh", City="Pune", Amount=5000, IsDelivered=true },
        new Order{ OrderId=2, Customer="Amit", City="Mumbai", Amount=12000, IsDelivered=false },
        new Order{ OrderId=3, Customer="Suresh", City="Pune", Amount=8000, IsDelivered=true },
        new Order{ OrderId=4, Customer="Raj", City="Delhi", Amount=3000, IsDelivered=false },
        new Order{ OrderId=5, Customer="Neha", City="Mumbai", Amount=15000, IsDelivered=true }
};

        public void RunAllExamples()
        {

            // ================= 1. WHERE =================
            Console.WriteLine("---- WHERE (Filter) ----");

            // Real-time: Get only delivered orders (API: /orders?delivered=true)
            var deliveredOrders = orders.Where(o => o.IsDelivered);

            foreach (var o in deliveredOrders)
                Console.WriteLine($"{o.Customer} - Delivered");


            // ================= 2. SELECT =================
            Console.WriteLine("\n---- SELECT (Projection) ----");

            // Real-time: Return only customer names (API response shaping)
            var customerNames = orders.Select(o => o.Customer);

            foreach (var name in customerNames)
                Console.WriteLine(name);


            // ================= 3. ORDERBY =================
            Console.WriteLine("\n---- ORDER BY Amount DESC ----");

            // Real-time: Sort orders by highest amount (Admin dashboard)
            var sortedOrders = orders.OrderByDescending(o => o.Amount);

            foreach (var o in sortedOrders)
                Console.WriteLine($"{o.Customer} - {o.Amount}");


            // ================= 4. FIRST OR DEFAULT =================
            Console.WriteLine("\n---- FIRST OR DEFAULT ----");

            // Real-time: Get first order from Pune (API: /orders/city/pune)
            var firstPune = orders.FirstOrDefault(o => o.City == "Pune");

            Console.WriteLine(firstPune?.Customer);


            // ================= 5. COUNT =================
            Console.WriteLine("\n---- COUNT ----");

            // Real-time: Count total Mumbai orders
            int mumbaiCount = orders.Count(o => o.City == "Mumbai");
            Console.WriteLine("Mumbai Orders: " + mumbaiCount);


            // ================= 6. SUM =================
            Console.WriteLine("\n---- SUM ----");

            // Real-time: Total revenue calculation
            double totalRevenue = orders.Sum(o => o.Amount);
            Console.WriteLine("Total Revenue: " + totalRevenue);


            // ================= 7. ANY =================
            Console.WriteLine("\n---- ANY ----");

            // Real-time: Check if any high value order > 14000 exists
            bool hasHighValue = orders.Any(o => o.Amount > 4000);
            Console.WriteLine("High value order exists? " + hasHighValue);


            // ================= 8. TAKE =================
            Console.WriteLine("\n---- TAKE (Top 2 Orders) ----");

            // Real-time: Show top 2 recent orders (API pagination)
            var topTwo = orders.Take(2);

            foreach (var o in topTwo)
                Console.WriteLine(o.Customer);


            // ================= 9. SKIP =================
            Console.WriteLine("\n---- SKIP (Pagination) ----");

            // Real-time: Page 2 data (skip first 2)
            var pageTwo = orders.Skip(2).Take(2);

            foreach (var o in pageTwo)
                Console.WriteLine(o.Customer);


            // ================= 10. GROUP BY =================
            Console.WriteLine("\n---- GROUP BY City ----");

            // Real-time: Group orders by city (Dashboard analytics)
            var groupByCity = orders.GroupBy(o => o.City);

            foreach (var group in groupByCity)
            {
                Console.WriteLine("City: " + group.Key);

                foreach (var o in group)
                    Console.WriteLine("  " + o.Customer);
            }
        }



        internal class Practice_LINQ_RealTime
        {
            class ProductOrder
            {
                public int OrderId { get; set; }
                public string? CustomerName { get; set; }
                public string? Email { get; set; }
                public string? ProductName { get; set; }
                public string? Category { get; set; }
                public string? City { get; set; }
                public DateTime OrderDate { get; set; }
                public double Price { get; set; }
                public int Quantity { get; set; }
                public bool IsPaid { get; set; }
                public bool IsDelivered { get; set; }
                public string? PaymentMethod { get; set; }
            }

            List<ProductOrder> orders = new List<ProductOrder>
    {
        new ProductOrder{ OrderId=1, CustomerName="Ramesh", Email="r1@gmail.com", ProductName="Laptop", Category="Electronics", City="Pune", OrderDate=DateTime.Now.AddDays(-10), Price=60000, Quantity=1, IsPaid=true, IsDelivered=true, PaymentMethod="UPI"},
        new ProductOrder{ OrderId=2, CustomerName="Amit", Email="a1@gmail.com", ProductName="Mobile", Category="Electronics", City="Mumbai", OrderDate=DateTime.Now.AddDays(-8), Price=25000, Quantity=2, IsPaid=true, IsDelivered=false, PaymentMethod="Card"},
        new ProductOrder{ OrderId=3, CustomerName="Neha", Email="n1@gmail.com", ProductName="Shoes", Category="Fashion", City="Delhi", OrderDate=DateTime.Now.AddDays(-7), Price=3000, Quantity=3, IsPaid=false, IsDelivered=false, PaymentMethod="COD"},
        new ProductOrder{ OrderId=4, CustomerName="Raj", Email="r2@gmail.com", ProductName="TV", Category="Electronics", City="Pune", OrderDate=DateTime.Now.AddDays(-6), Price=45000, Quantity=1, IsPaid=true, IsDelivered=true, PaymentMethod="Card"},
        new ProductOrder{ OrderId=5, CustomerName="Priya", Email="p1@gmail.com", ProductName="Watch", Category="Fashion", City="Mumbai", OrderDate=DateTime.Now.AddDays(-5), Price=7000, Quantity=2, IsPaid=true, IsDelivered=true, PaymentMethod="UPI"},
        new ProductOrder{ OrderId=6, CustomerName="Suresh", Email="s1@gmail.com", ProductName="Headphones", Category="Electronics", City="Chennai", OrderDate=DateTime.Now.AddDays(-4), Price=4000, Quantity=1, IsPaid=false, IsDelivered=false, PaymentMethod="COD"},
        new ProductOrder{ OrderId=7, CustomerName="Anita", Email="a2@gmail.com", ProductName="Bag", Category="Fashion", City="Delhi", OrderDate=DateTime.Now.AddDays(-3), Price=2500, Quantity=4, IsPaid=true, IsDelivered=false, PaymentMethod="UPI"},
        new ProductOrder{ OrderId=8, CustomerName="Kiran", Email="k1@gmail.com", ProductName="Tablet", Category="Electronics", City="Hyderabad", OrderDate=DateTime.Now.AddDays(-2), Price=20000, Quantity=1, IsPaid=true, IsDelivered=true, PaymentMethod="Card"},
        new ProductOrder{ OrderId=9, CustomerName="Vikas", Email="v1@gmail.com", ProductName="Camera", Category="Electronics", City="Pune", OrderDate=DateTime.Now.AddDays(-12), Price=55000, Quantity=1, IsPaid=true, IsDelivered=false, PaymentMethod="UPI"},
        new ProductOrder{ OrderId=10, CustomerName="Meena", Email="m1@gmail.com", ProductName="Dress", Category="Fashion", City="Mumbai", OrderDate=DateTime.Now.AddDays(-15), Price=5000, Quantity=2, IsPaid=false, IsDelivered=false, PaymentMethod="COD"},

        // 15 More Records
        new ProductOrder{ OrderId=11, CustomerName="Arjun", Email="ar@gmail.com", ProductName="Laptop", Category="Electronics", City="Delhi", OrderDate=DateTime.Now.AddDays(-1), Price=65000, Quantity=1, IsPaid=true, IsDelivered=false, PaymentMethod="Card"},
        new ProductOrder{ OrderId=12, CustomerName="Riya", Email="ri@gmail.com", ProductName="Shoes", Category="Fashion", City="Pune", OrderDate=DateTime.Now.AddDays(-9), Price=3200, Quantity=2, IsPaid=true, IsDelivered=true, PaymentMethod="UPI"},
        new ProductOrder{ OrderId=13, CustomerName="Manoj", Email="ma@gmail.com", ProductName="Mobile", Category="Electronics", City="Chennai", OrderDate=DateTime.Now.AddDays(-11), Price=28000, Quantity=1, IsPaid=true, IsDelivered=true, PaymentMethod="Card"},
        new ProductOrder{ OrderId=14, CustomerName="Sneha", Email="sn@gmail.com", ProductName="TV", Category="Electronics", City="Hyderabad", OrderDate=DateTime.Now.AddDays(-13), Price=40000, Quantity=1, IsPaid=false, IsDelivered=false, PaymentMethod="COD"},
        new ProductOrder{ OrderId=15, CustomerName="Kunal", Email="ku@gmail.com", ProductName="Watch", Category="Fashion", City="Mumbai", OrderDate=DateTime.Now.AddDays(-14), Price=8000, Quantity=1, IsPaid=true, IsDelivered=true, PaymentMethod="UPI"},
        new ProductOrder{ OrderId=16, CustomerName="Nikhil", Email="ni@gmail.com", ProductName="Headphones", Category="Electronics", City="Pune", OrderDate=DateTime.Now.AddDays(-20), Price=4500, Quantity=2, IsPaid=true, IsDelivered=true, PaymentMethod="Card"},
        new ProductOrder{ OrderId=17, CustomerName="Divya", Email="di@gmail.com", ProductName="Bag", Category="Fashion", City="Delhi", OrderDate=DateTime.Now.AddDays(-18), Price=3500, Quantity=1, IsPaid=false, IsDelivered=false, PaymentMethod="COD"},
        new ProductOrder{ OrderId=18, CustomerName="Harsh", Email="ha@gmail.com", ProductName="Tablet", Category="Electronics", City="Mumbai", OrderDate=DateTime.Now.AddDays(-17), Price=21000, Quantity=1, IsPaid=true, IsDelivered=true, PaymentMethod="UPI"},
        new ProductOrder{ OrderId=19, CustomerName="Rohit", Email="ro@gmail.com", ProductName="Camera", Category="Electronics", City="Chennai", OrderDate=DateTime.Now.AddDays(-16), Price=52000, Quantity=1, IsPaid=true, IsDelivered=false, PaymentMethod="Card"},
        new ProductOrder{ OrderId=20, CustomerName="Pooja", Email="po@gmail.com", ProductName="Dress", Category="Fashion", City="Hyderabad", OrderDate=DateTime.Now.AddDays(-19), Price=6000, Quantity=3, IsPaid=true, IsDelivered=true, PaymentMethod="UPI"},
        new ProductOrder{ OrderId=21, CustomerName="Ajay", Email="aj@gmail.com", ProductName="Mobile", Category="Electronics", City="Pune", OrderDate=DateTime.Now.AddDays(-21), Price=26000, Quantity=1, IsPaid=false, IsDelivered=false, PaymentMethod="COD"},
        new ProductOrder{ OrderId=22, CustomerName="Isha", Email="is@gmail.com", ProductName="Shoes", Category="Fashion", City="Mumbai", OrderDate=DateTime.Now.AddDays(-22), Price=3100, Quantity=2, IsPaid=true, IsDelivered=true, PaymentMethod="Card"},
        new ProductOrder{ OrderId=23, CustomerName="Varun", Email="va@gmail.com", ProductName="Laptop", Category="Electronics", City="Delhi", OrderDate=DateTime.Now.AddDays(-23), Price=70000, Quantity=1, IsPaid=true, IsDelivered=true, PaymentMethod="UPI"},
        new ProductOrder{ OrderId=24, CustomerName="Kavya", Email="ka@gmail.com", ProductName="Bag", Category="Fashion", City="Chennai", OrderDate=DateTime.Now.AddDays(-24), Price=2800, Quantity=2, IsPaid=false, IsDelivered=false, PaymentMethod="COD"},
        new ProductOrder{ OrderId=25, CustomerName="Yash", Email="ya@gmail.com", ProductName="TV", Category="Electronics", City="Pune", OrderDate=DateTime.Now.AddDays(-25), Price=48000, Quantity=1, IsPaid=true, IsDelivered=true, PaymentMethod="Card"},
    };

           
            public void LINQExample()
            {
                //            ✅ WHERE(Filtering)

                //Console.WriteLine("========================== WHERE(Filtering) =======================");

                //Get all orders where City = "Pune"

                var result = orders.Where(o => o.City == "Pune");

                foreach (var item in result)
                {
                    //Console.WriteLine($"CustomerName : '{item.CustomerName}' whose city is pune");
                }

                //Get all unpaid orders

                var result1 = orders.Where(o => o.IsPaid==false);

                foreach (var item in result1)
                {
                    //Console.WriteLine($"unpaid orders '{item.CustomerName} - {item.ProductName}' ");
                }

                //Get all Electronics category orders

                var result2 = orders.Where(o => o.Category == "Electronics");
                foreach (var item in result2)
                {
                    //Console.WriteLine($" Electronics : '{item.Email}'");
                }

                //Get orders where Price > 30000

                var result3 = orders.Where(o => o.Price > 30000);
                foreach (var item in result2)
                {
                    //Console.WriteLine($" Price > 30000 : '{item.CustomerName}'");
                }



                //                ✅ SELECT(Projection)

                //Console.WriteLine("========================== SELECT(Projection) =======================");

                //Get only CustomerName list in UPPERCASE

                var Selectresult = orders.Select(o => o.CustomerName);
                foreach (var item in Selectresult)
                {
                    //Console.WriteLine(item?.ToUpper());
                }

                //Get ProductName and Price only

                var Selectresult2 = orders.Select(o => new { o.CustomerName , o.Price} );
                foreach (var item in Selectresult2)
                {
                    //Console.WriteLine(item);
                }

                //Get OrderId and TotalAmount(Price × Quantity)

                var Selectresult3 = orders.Select(o => new { o.OrderId, TotalAmount = o.Price*o.Quantity });
                foreach (var item in Selectresult3)
                {
                    //Console.WriteLine(item);
                }

                //Get Email list of delivered customers

                var Selectresult4 = orders.Where(o => o.IsDelivered).Select(o => o.Email);
                foreach (var item in Selectresult2)
                {
                    //Console.WriteLine(item);
                }



                //                ✅ ORDERBY / ORDERBYDESCENDING

                //Console.WriteLine("========================== ORDERBY / ORDERBYDESCENDING =======================");

                //Sort by Price ascending

                var OrderByResult = orders.OrderBy(o => o.Price);
                foreach (var item in OrderByResult)
                {
                    //Console.WriteLine($"{item.CustomerName} - {item.Price}");
                }

                //Sort by Price descending

                var OrderByResult2 = orders.OrderByDescending(o => o.Price);
                foreach (var item in OrderByResult2)
                {
                    //Console.WriteLine($"{item.CustomerName} - {item.Price}");
                }

                //Sort by OrderDate latest first

                var OrderByResult3 = orders.OrderByDescending(o => o.OrderDate);
                foreach (var item in OrderByResult3)
                {
                    //Console.WriteLine($"{item.CustomerName} - {item.OrderDate}");
                }

                //Sort by CustomerName alphabetically

                var OrderByResult4 = orders.OrderBy(o => o.CustomerName);
                foreach (var item in OrderByResult4)
                {
                    //Console.WriteLine($"{item.CustomerName}");
                }


                //                ✅ FIRST / FIRSTORDEFAULT

                Console.WriteLine("========================== FIRST / FIRSTORDEFAULT =======================");

                //Get first unpaid order

                var FirstOrDefaultResult = orders.FirstOrDefault(o => o.IsPaid == false);
                Console.WriteLine(FirstOrDefaultResult?.CustomerName);   
                

                //Get first order from Mumbai



                //Get first Electronics order

                //Get first order with Quantity > 2

            }
        }


    }
}
