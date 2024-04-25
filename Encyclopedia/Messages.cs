using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encyclopedia
{
    static internal class Messages
    {
        public static void Hello() // Public is the access modifier, allowing us to use it outside this class
        {
            Console.WriteLine("Hello, Welcome to this program!");
        }
        public static void Waiting() // Static means that this method and what it does does not belong to a single object it is created
                                    // with, it means it belongs to the class it stays within. Think of it like this, instead if making
                                    // an instance of a variable EVRY SINGLE TIME you use a single variable, shared across all instances
        {
            Console.WriteLine("Im waiting for something!");
        }
        public static void Bye() // Void is simply that it isnt supposed to return anything
        {
            Console.WriteLine("Bye! Thanks for visiting!");
        }
    }
}
