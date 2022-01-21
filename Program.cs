using System;
using CSharpTutorial.Calc;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1, num2;
            int n1, n2;
            while (true)
            {
                num1 = num2 = "";
                n1 = n2 = 0;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Welcome to \"The Calculator.\" First select and operator ( + , - , * , / )");
                Console.ResetColor();

                string oper = Console.ReadLine();

                if (oper == "+")
                {
                    Console.WriteLine("Pick your first number.");
                    num1 = Console.ReadLine();
                    while(!int.TryParse(num1, out int result))
                    {
                        Console.WriteLine("Try Again, but with a real number.");
                        num1 = Console.ReadLine();
                    }
                    n1 = Int32.Parse(num1);

                    Console.WriteLine("Pick your second number.");
                    num2 = Console.ReadLine();
                    while (!int.TryParse(num2, out int result))
                    {
                        Console.WriteLine("Try Again, but with a real number.");
                        num2 = Console.ReadLine();
                    }
                    n2 = Int32.Parse(num2);
                    Console.WriteLine("Your answer is " + Calculator.Add(n1, n2));
                }
                else if (oper == "-")
                {
                    Console.WriteLine("Pick your first number.");
                    num1 = Console.ReadLine();
                    while (!int.TryParse(num1, out int result))
                    {
                        Console.WriteLine("Try Again, but with a real number.");
                        num1 = Console.ReadLine();
                    }
                    n1 = Int32.Parse(num1);

                    Console.WriteLine("Pick your second number.");
                    num2 = Console.ReadLine();
                    while (!int.TryParse(num2, out int result))
                    {
                        Console.WriteLine("Try Again, but with a real number.");
                        num2 = Console.ReadLine();
                    }
                    n2 = Int32.Parse(num2);
                    Console.WriteLine("Your answer is " + Calculator.Subtract(n1, n2));
                }
                else if (oper == "*")
                {
                    Console.WriteLine("Pick your first number.");
                    num1 = Console.ReadLine();
                    while (!int.TryParse(num1, out int result))
                    {
                        Console.WriteLine("Try Again, but with a real number.");
                        num1 = Console.ReadLine();
                    }
                    n1 = Int32.Parse(num1);

                    Console.WriteLine("Pick your second number.");
                    num2 = Console.ReadLine();
                    while (!int.TryParse(num2, out int result))
                    {
                        Console.WriteLine("Try Again, but with a real number.");
                        num2 = Console.ReadLine();
                    }
                    n2 = Int32.Parse(num2);
                    Console.WriteLine("Your answer is " + Calculator.Multiply(n1, n2));
                }
                else if (oper == "/")
                {
                    Console.WriteLine("Pick your first number.");
                    num1 = Console.ReadLine();
                    while (!int.TryParse(num1, out int result))
                    {
                        Console.WriteLine("Try Again, but with a real number.");
                        num1 = Console.ReadLine();
                    }
                    n1 = Int32.Parse(num1);

                    Console.WriteLine("Pick your second number.");
                    num2 = Console.ReadLine();
                    while (!int.TryParse(num2, out int result))
                    {
                        Console.WriteLine("Try Again, but with a real number.");
                        num2 = Console.ReadLine();
                    }
                    n2 = Int32.Parse(num2);
                    Console.WriteLine("Your answer is " + Calculator.Divide(n1, n2));
                }
                else 
                {
                    Console.WriteLine("BRUH, pick an OPERATOR not whatever you just typed.");
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Do you want to go again? Y = yes | Everything else = no");
                Console.ResetColor();

                string response = Console.ReadLine().ToUpper();
                if (response == "Y")
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
