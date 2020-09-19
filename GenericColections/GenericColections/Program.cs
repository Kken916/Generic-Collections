using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericColections
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("This is generic Collections");
            Console.WriteLine("best if viewed in full screen console window, press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Collections.Lists();
            Collections.LinkedLists();
            Collections.Queues();
            Collections.TheStack();
            Collections.Dictionaries();
            Collections.SortedLists();
            Collections.HashSets();
            Console.ReadLine();
        }
    }
}
