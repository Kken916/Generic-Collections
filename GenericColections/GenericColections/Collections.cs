using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericColections
{
    public static class Collections
    {
        public static void Lists()
        {
            List<string> list = new List<string>();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("The animals(string) come from the List<T> class.");
            list.Add("Dog");
            list.Add("Cat");
            list.Add("Fish");
            list.Add("Horse");
            list.Add("Pig");
            foreach (string a in list)
            {

                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine("The List<T> class is the generic equivalent of the ArrayList class. It implements the IList<T> generic interface by using an array whose size is dynamically increased as required.");

        }
        public static void LinkedLists()
        {
            LinkedList<int> numbers = new LinkedList<int>();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\nThese itegers come from the LinkedList<T> class.");
            foreach (int number in new int[] { 10, 8, 6, 4, 2 })
            {
                numbers.AddFirst(number);
                Console.WriteLine(number);  
            }
            Console.WriteLine("Each node in a LinkedList<T> object is of the type LinkedListNode<T>. Because the LinkedList<T> is doubly linked, each node points forward to the Next node and backward to the Previous node.");
        }
        public static void Queues()
        {
            Queue<int> queue = new Queue<int>();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\nThese itegers come from the Queue<T> class.");
            Console.WriteLine("Populating the queue:");
            foreach (int number in new int[5] { 9, 3, 7, 2, 1})
            {
                queue.Enqueue(number);
                Console.WriteLine($"{number} has joined the queue");
            }
            Console.WriteLine("The Queue<T> class implements a first-in, first-out mechanism. An element is inserted into the queue at the back(the Enqueue operation) and is removed from the queue at the front(the Dequeue operation).");
        }
         public static void TheStack()
        {
            Stack<int> numbers = new Stack<int>();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\nThese itegers from the Stack<T> class.");
            Console.WriteLine("Pushing items onto the stack:");
            foreach (int number in new int[5] { 9, 3, 7, 2, 1 })
            {
                numbers.Push(number);
                Console.WriteLine($"{number} has been pushed on the stack");
            }
            Console.WriteLine("The Stack<T> class implements a last-in, first-out mechanism. An element joins the stack at the top (the push operation) and leaves the stack at the top(the pop operation)");
        }
        public static void Dictionaries()
        {
            Dictionary<string, int> people = new Dictionary<string, int>();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\nThe (string, int) datatype are from the Dictionary<TKey, TValue> class.");
            people.Add("kenny", 23); // using the Add method
            people.Add("Sangyi", 23);
            people.Add("Phillip", 27);
            people["Patrick"] = 24; // using array notation
            people["Enrigue"] = 23;
            Console.WriteLine("The Dictionary contains:");
            foreach (KeyValuePair<string, int> element in people)
            {
                string name = element.Key;
                int age = element.Value;
                Console.WriteLine($"Name: {name}, Age: {age}");
            }
            Console.WriteLine("The Dictionary<TKey,TValue> generic class provides a mapping from a set of keys to a set of values. Each addition to the dictionary consists of a value and its associated key");
        }
        public static void SortedLists()
        { 
            SortedList<string, int> people = new SortedList<string, int>();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\nThe (string, int) datatype are from the SortedList<TKey, TValue> class.");
            people.Add("kenny", 23); 
            people.Add("Sangyi", 23);
            people.Add("Phillip", 27);
            people["Patrick"] = 24;
            people["Enrigue"] = 23;
            Console.WriteLine("The SortedList contains:");
            foreach (KeyValuePair<string, int> element in people)
            {
                string name = element.Key;
                int age = element.Value;
                Console.WriteLine($"Name: {name}, Age: {age}");
            }        
            Console.WriteLine("The SortedList<TKey, TValue> class is very similar to the Dictionary<TKey, TValue> class in that you can use it to associate keys with values.");
            Console.WriteLine("The primary difference is that the keys array is always sorted. (It is called a SortedList, after all.)");
            Console.WriteLine("It takes longer to insert data into a SortedList < TKey, TValue > object than aSortedDictionary < TKey, TValue > object in most cases, but data retrieval is often quicker (or at least as quick), and the SortedList < TKey, TValue > class uses less memory");
        }
        public static void HashSets()
        {
            HashSet<string> friends = new HashSet<string>(new string[] { "Tray", "Chris", "Joel", "Sangyi", "Enrique" });
            HashSet<string> students = new HashSet<string>(new string[] { "Johnny", "Dee", "Sanygi", "Jorge", "Enrique" });
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" =These values come from the HashSet<T> class.");
            friends.Add("Phillip");
            students.Add("Phillip");
            students.Add("Zack");
            Console.WriteLine("Friends:");
            foreach (string name in friends)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("");
            Console.WriteLine("Students:");
            foreach (string name in students)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\nStudents who are also Friends:");
            students.IntersectWith(friends);
            foreach (string name in students)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("The HashSet<T> class is optimized for performing set operations, such as determining set membership and generating the union and intersection of sets.");
        }

    }
}
