using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo2
{
    internal class CollectionsDemo
    {
        public static void List()
        {
            List<int> list = new List<int>();
            list.Add(50);
            list.Add(40);
            list.Add(20);
            list.Add(70);
            list.Add(90);

            Console.WriteLine("\nItems in List are: ");
            foreach (var Items in list)
            {
                Console.WriteLine(Items);
            }
        }

        public static void Dictinoary()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(45, "pen");
            dictionary.Add(44, "pencil");
            dictionary.Add(90, "book");
            dictionary.Add(77, "table");
            string keyvalue = dictionary[90];
            Console.WriteLine("\nItems in Dictinory are: ");

            foreach (var element in dictionary)
            {
                Console.WriteLine("Key : " + element.Key + " Value : " + element.Value);
            }
            Console.WriteLine("Value of 3 element in dictionary: " + keyvalue);
        }

        public static void Set()
        {
            var set = new HashSet<int>();
            set.Add(99);
            set.Add(88);
            set.Add(77);
            set.Add(66);
            set.Add(9);

            Console.WriteLine("\nItems in Set are: ");
            HashSet<int>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.MoveNext());
            }
        }

        public static void Stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);
            int pop = stack.Pop();

            Console.WriteLine("\nItems in Stack are: ");
            foreach (var Items in stack)
            {
                Console.WriteLine(Items);
            }
            Console.WriteLine("Deleted value is: " + pop);
        }

        public static void Queue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(89);
            queue.Enqueue(90);
            queue.Enqueue(12);
            queue.Enqueue(56);
            queue.Enqueue(1);
            int Peek = queue.Peek();
            int dequeue = queue.Dequeue();

            Console.WriteLine("\nItems in Queue are: ");
            foreach (var Items in queue)
            {
                Console.WriteLine(Items);
            }
            Console.WriteLine("Peek value is: " + Peek);
            Console.WriteLine("Peek value is: " + dequeue);
        }
    }
}
