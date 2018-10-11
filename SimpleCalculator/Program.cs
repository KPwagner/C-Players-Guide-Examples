/*
This program was created by Kyle Wagner while working through The C# Player's Guide (R.B. Whitaker).
Anyone is free use, copy, or change this program without permission.
*/
using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to Simple Calculator." +
                              "\nHere, you can input two numbers and an operator to get the result.");

            // Gets first operand from user
            Console.WriteLine("\nPlease enter your first number as any integer:");
            string userInput = Console.ReadLine();
            double firstOperand = Convert.ToDouble(userInput);

            // Gets second operand from user
            Console.WriteLine("\nPlease enter your second number as any integer:");
            userInput = Console.ReadLine();
            double secondOperand = Convert.ToDouble(userInput);

            // Gets operator from user
            Console.WriteLine("\nPlease enter the operator that you want to use (+, -, *, /, %, or ^):");
            string userOperator = Console.ReadLine();

            // Computes and prints the result with an explanitory message
            double output;
            switch (userOperator)
            {
                case "+":
                    output = firstOperand + secondOperand;
                    Console.WriteLine($"The result of adding {firstOperand} and {secondOperand} is {output}.");
                    break;
                case "-":
                    output = firstOperand - secondOperand;
                    Console.WriteLine($"The result of substracting {secondOperand} from {firstOperand} is {output}.");
                    break;
                case "*":
                    output = firstOperand * secondOperand;
                    Console.WriteLine($"The result of multiplying {firstOperand} and {secondOperand} is {output}.");
                    break;
                case "/":
                    output = firstOperand / secondOperand;
                    Console.WriteLine($"The result of dividing {firstOperand} by {secondOperand} is {output}.");
                    break;
                case "%":
                    output = firstOperand % secondOperand;
                    Console.WriteLine($"The remainder after dividing {firstOperand} by {secondOperand} is {output}.");
                    break;
                case "^":
                    output = Math.Pow(firstOperand, secondOperand);
                    Console.WriteLine($"The result of raising {firstOperand} to the power of {secondOperand} is {output}.");
                    break;
                default:
                    Console.WriteLine($"Sorry, but the operator you provided does not work with this calculator." +
                                      "\nIt's only a simple calculator afterall.");
                    break;
            }
        }
    }
}
