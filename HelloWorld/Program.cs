/*
This simple program contains many superfluous comments, which exist for the purpose of practice.

The following 'using' directives setup the external code that this program will use.
By default, Visual Studio includes only the 'using System' directive, however I included
four additional directives based on the example code provided in The C# Player's Guide book.
The additional directives' importance is not clear, given the program runs fine without them.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// One namespace HelloWorld, which supersedes all member classes and methods.
namespace HelloWorld
{
    // One class (Program), with a single member method (Main).
    class Program
    {
        // One method (Main); make changes here to get different output.
        static void Main(string[] args)
        {
            // Opens a command line and prints "Hello World!", a common first task when learning a new language.
            Console.WriteLine("Hello World!");
            // ReadKey waits for the user to press a key before completing the program. 
            // This prevent the prompt from immediately disappearing upon running.
            // It's not clear whether or not ReadKey is necessary to prevent the undesired prompt flicker effect.
            Console.ReadKey();
            // Another use of WriteLine with a famous line from 2001: A Space Odyssey.
            Console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that.");
            // A final ReadKey so the user won't miss the classic line.
            Console.ReadKey();
        }
    }
}