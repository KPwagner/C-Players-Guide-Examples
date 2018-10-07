using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1.
            Section 1 declares, assigns, reassigns, and prints a few variables.
            This section is based on chapter 5 (Variables) from The C# Player's Guide.
            */

            // Declares a variable as an integer.
            int score;
            // Assigns a value to the score variable.
            score = 0;
            // Declares and assigns a value in a single line.
            int theMeaningOfLife = 42;
            // Prints the value of the score variable to the console.
            Console.WriteLine(score);
            Console.ReadKey();
            Console.WriteLine(theMeaningOfLife);
            Console.ReadKey();

            // Declares and assigns value to two variables (a and b)
            int a = 5;
            int b = 2;
            // Reassigns values to variables b and a.
            // What will there values be after this assignment?
            b = a;
            a = -3;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();

            /*
            2.
            Section 2 creates and prints 14 variables, 13 simple and 1 string, each with a different type.
            This sectionis based on chapter 6 (The C# Type System) from The C# Player's Guide.
            */

            // Integral type variables
            byte one = 157;
            Console.WriteLine("This is a byte-type variable (unsigned with a value range 0 to 255):");
            Console.WriteLine(one);

            sbyte two = -15;
            Console.WriteLine("This is an sbyte-type variable (signed with a value range -128 to 127):");
            Console.WriteLine(two);

            short three = -1276;
            Console.WriteLine("This is an int-type variable (signed with a value range -32,768 to 32,767):");
            Console.WriteLine(three);

            ushort four = 21843;
            Console.WriteLine("This is a ushort-type variable (unsigned with a value range of 0 to 65,535):");
            Console.WriteLine(four);

            int five = -43000;
            Console.WriteLine("This is an int-type variable (signed with a value range of -2,147,483,648 to 2,147,483,647):");
            Console.WriteLine(five);

            uint six = 45000;
            Console.WriteLine("This is a uint-type variable (unsigned with a value range of 0 to 4,294,967,295):");
            Console.WriteLine(six);

            long seven = -9876543210;
            Console.WriteLine("Ths is a long-type variable (signed with a value range of -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807):");
            Console.WriteLine(seven);

            ulong eight = 9876543210;
            Console.WriteLine("This is a ulong-type variable (unsigned with a value range of 0 to 18,446,774,073,709,551,615):");
            Console.WriteLine(eight);

            char nine = 'c';
            Console.WriteLine("This is a char-type variable (range of U+0000 to U+ffff, all unicode characters):");
            Console.WriteLine(nine);

            // Floating point type variables
            float ten = 3.1415926f; // 'F' or 'f' makes the variable a float literal
            Console.WriteLine("This is a float-type variable (signed with a range of +/-1.0e-45 to +/-3.4e38 and 7 digits of precision):");
            Console.WriteLine(ten);

            double eleven = 3.14159265358979323846;
            Console.WriteLine("This is a double-type variable (signed with a range of +/-5e-324 to +/-1.7e308 and 15 or 16 digits of precision):");
            Console.WriteLine(eleven);

            decimal twelve = 3.14m; // 'M' or 'm' makes the variable a decimal literal
            Console.WriteLine("This is a decimal-type variable (signed with a range of +/-1.0*10e-28 to +/-7.9e28 and 28 or 29 digits of precision):");
            Console.WriteLine(twelve);

            // Bool type variable
            bool thirteen = true;
            Console.WriteLine("This is a bool-type variable, which has a possible value of either true or false:");
            Console.WriteLine(thirteen);

            // String type variable
            string fourteen = "Hello World!";
            Console.WriteLine("This is a string-type variable:");
            Console.WriteLine(fourteen);
        }
    }
}
