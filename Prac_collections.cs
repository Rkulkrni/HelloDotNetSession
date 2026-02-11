//      COLLECTIONS :-


// Collections standardize the way of which the objects are handled by your program.

// In other words, it contains a set of classes to contain elements in a generalized manner.

// With the help of collections, the user can perform several operations on objects like the store, update, delete, retrieve, search, sort etc. C#



using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HelloDotNetSession
{
    internal class Prac_collections
    {

        // A collection is a container that stores multiple values.

        // =====================================================
        // 1️. ARRAY
        // Fixed size collection
        // Fastest, simple, index based

        // An array is a linear data structure that stores a fixed-size sequence of elements of the same data type in contiguous memory locations.
        // It allows accessing elements using an index, starting from 0.

        // =====================================================

        public void GetArray()
        {

            // SYNTAX :- datatype [ ] < Name_Array > = new < datatype > [size];

            Console.WriteLine("-------------------------- Array ---------------------------");
            int[] ArrayPlayers = { 10, 20, 30, 40, 50 };

            Console.Write("For Loop :");

            for (int i = 0; i < ArrayPlayers.Length; i++)
            {
                Console.Write(" " + ArrayPlayers[i] + " ");
            }

            Console.WriteLine("");
            Console.Write("For Each Loop :");

            foreach (var item in ArrayPlayers)
            {
                Console.Write($"values are: {item} ");
            }

            Console.WriteLine("");
            Console.Write("while loop :");

            int j = 0;
            while (j < ArrayPlayers.Length)
            {
                Console.Write(" " + ArrayPlayers[j] + " ");
                j++;
            }

            Console.WriteLine("");
            Console.Write("Do-while loop :");

            int k = 0;
            do
            {
                Console.Write(" " + ArrayPlayers[k] + " ");
                k++;
            } while (k < ArrayPlayers.Length);

            Console.WriteLine("");
            Console.WriteLine("");
        }


        // =====================================================
        // 2️. LIST<T>
        // Dynamic size (can grow/shrink)
        // Most used in real projects

        // Key Features of List<T> in C#

        // Unlike arrays, List<T> can grow or shrink dynamically as elements are added or removed.
        // Allows duplicate elements and accepts null values for reference types.
        // Provides built-in methods to add, remove, search, sort and manipulate elements.
        // Not sorted by default, elements are accessed using a zero-based index.
        // Capacity grows automatically when needed by reallocating the internal array.
        // Generic equivalent of ArrayList, implementing IList<T> for type safety.

        // =====================================================


        public void GetList()
        {

            // SYNTAX :- List<T> listName = new List<T>();

            Console.WriteLine("-------------------------- List ---------------------------");
            List<string> Student = new List<string>();

            Student.Add("Rohit");
            Student.Add("Virat");
            Student.Add("Hardik");
            Student.Add("Surya");

            Student.Remove("Surya");

            foreach (var item in Student)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");

            List<string> CartItems = new List<string>
            {
                "Laptop",
                "Mouse",
                "Mobile",
                "Keyboard"
            };

            CartItems.Remove("Mobile");

            Console.Write("Items reamaining in the Cart : ");
            foreach (var item in CartItems)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            List<int> BookedSeat = new List<int>();

            BookedSeat.Add(5);
            BookedSeat.Add(8);
            BookedSeat.Add(10);
            BookedSeat.Add(3);

            Console.Write("Booked Seats : ");
            foreach (var item in BookedSeat)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine("");
            Console.WriteLine("");
        }


        // =====================================================
        // 3️. DICTIONARY<TKey, TValue>
        // Key-Value pair
        // Fast searching  /  It is fast to find data using a key
        // Key must be unique BUT Values can repeat
        // =====================================================


        public void GetDictionary()
        {

            // SYNTAX :-   Dictionary<KeyType, ValueType> name = new Dictionary<KeyType, ValueType>();

            Console.WriteLine("-------------------------- Dictionary ---------------------------");

            Dictionary<int, string> Students = new Dictionary<int, string>();

            Students.Add(101, "Ramesh");
            Students.Add(102, "Shubham");
            Students.Add(103, "Sanket");
            Students.Add(104, "Shivraj");

            Console.WriteLine("Student List : ");
            foreach (var item in Students)
            {
                Console.WriteLine($" the student whos id is |{item.Key}| has username |{item.Value}| ");

            }
            Console.WriteLine("");

            Dictionary<string, int> products = new Dictionary<string, int>
            {
                {"Laptop",550000 },
                {"Mobile", 35000 },
                {"TV", 85000 }
            };

            Console.WriteLine("Product Prices : ");
            foreach (var item in products)
            {
                Console.WriteLine($"the price of |{item.Key}| is |{item.Value}|");
            }
            Console.WriteLine("");

            Dictionary<int, string> busSeats = new Dictionary<int, string>();

            busSeats.Add(1, "Ravi");
            busSeats.Add(2, "Rohit");
            busSeats.Add(3, "Ajay");

            Console.WriteLine("Bus Bookings : ");
            foreach (var item in busSeats)
            {
                Console.WriteLine($"seat number |{item.Key}| has been reserved for the |{item.Value}|");
            }
            Console.WriteLine("");
        }


        // =====================================================

        // 6. HASHSET
        // Only unique values
        // No duplicates allowed
        // Fast lookup

        //HashSet<T> class is an unordered collection of unique elements

        // =====================================================

        public void GetHashSet()
        {

            // SYNTAX :-  HashSet<T> hs = new HashSet<T>();

            HashSet<string> UserNames = new HashSet<string>();

            UserNames.Add("Ramesh123");
            UserNames.Add("Devil007");
            UserNames.Add("Rohit444");
            UserNames.Add("Ramesh123");

            Console.WriteLine("Registered Usernames:");
            foreach (var item in UserNames)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
        }


        // =====================================================

        // 4️. STACK
        // LIFO (Last In First Out)
        // Example: Undo, Browser Back

        // =====================================================

        public void GetStack()
        {

            // SYNTAX :- Stack<Type> name = new Stack<Type>();

            Stack<string> history = new Stack<string>();

            history.Push("Google");
            history.Push("Youtube");
            history.Push("Instagram");

            Console.WriteLine("Search History :");
            foreach(var item in history)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Pop element : "+history.Pop());
        }



        // =====================================================

        // 5️. QUEUE

        // FIFO (First In First Out)
        // Example: Ticket counter

        // =====================================================
        public void GetQueue()
        {

            // SYNTAX :- Queue<Type> name = new Queue<Type>();

            Queue<string> history = new Queue<string>();

            history.Enqueue("Google");
            history.Enqueue("Youtube");
            history.Enqueue("Instagram");

            Console.WriteLine("Search History :");
            foreach (var item in history)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
        }

    }
}
