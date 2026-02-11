using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetSession
{
    internal class Collections
    {
        // A collection is a container that stores multiple values.

        // =====================================================
        // 1️. ARRAY
        // Fixed size collection
        // Fastest, simple, index based
        // =====================================================
        public void ArrayExample()
        {
            // declare + initialize
            string[] players = { "Dhoni", "Virat", "Rohit" };
            // access using index
            Console.WriteLine(players[0]); // Dhoni
            // loop
            foreach (var p in players)
                Console.WriteLine(p);
        }

        // =====================================================
        // 2️. LIST<T>
        // Dynamic size (can grow/shrink)
        // Most used in real projects
        // =====================================================
        public void ListExample()
        {

            List<string> users = new List<string>();

            users.Add("Rahul");
            users.Add("Amit");
            users.Add("Suraj");

            users.Remove("Amit"); // remove item

            foreach (var u in users)
                Console.WriteLine(u);
        }

        // =====================================================
        // 3️. DICTIONARY<TKey, TValue>
        // Key-Value pair
        // Fast searching
        // Key must be unique
        // =====================================================
        public void DictionaryExample()
        {

            Dictionary<int, string> players = new Dictionary<int, string>();

            players.Add(7, "Dhoni");
            players.Add(18, "Virat");

            // access using key
            //Console.WriteLine(players[7]);

            foreach (var item in players)
                Console.WriteLine($"{item}");
            //Console.WriteLine($"{item.Key} -> {item.Value}");
        }

        // =====================================================
        // 4️. STACK
        // LIFO (Last In First Out)
        // Example: Undo, Browser Back
        // =====================================================
        public void StackExample()
        {

            Stack<string> stack = new Stack<string>();

            stack.Push("Page1");
            stack.Push("Page2");
            stack.Push("Page3");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(stack.Pop()); // Page3
            //Console.WriteLine(stack.Peek()); // Page2
        }

        // =====================================================
        // 5️. QUEUE
        // FIFO (First In First Out)
        // Example: Ticket counter
        // =====================================================
        public void QueueExample()
        {

            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Customer1");
            queue.Enqueue("Customer2");
            queue.Enqueue("Customer3");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(queue.Dequeue()); // Customer1
            //Console.WriteLine(queue.Peek()); // Customer2
        }

        // =====================================================
        // 6️. HASHSET
        // Only unique values
        // No duplicates allowed
        // Fast lookup
        // =====================================================
        public void HashSetExample()
        {

            HashSet<int> numbers = new HashSet<int>();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(10); // duplicate ignored

            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
