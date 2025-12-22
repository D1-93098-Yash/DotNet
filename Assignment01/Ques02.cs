using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01
{
    internal class Ques02
    {
        public static void Main(string[] args)
        {
            int a, b;
            string choice;
            Console.WriteLine("Enter two numbers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your choice (+, -, *, /): ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "+":
                    Console.WriteLine("Addition: " + (a + b));
                    break;
                case "-":
                    Console.WriteLine("Subtraction: " + (a - b));
                    break;
                case "*":
                    Console.WriteLine("Multiplication: " + (a * b));
                    break;
                case "/":
                    Console.WriteLine("Division: " + (a / b));
                    break;
            }
        }
    }
}
