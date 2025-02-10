using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003.Demotest
{
    class Q5
    {
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add two numbers");
                Console.WriteLine("2. Subtract two numbers");
                Console.WriteLine("3. Multiply two numbers");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter first number: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Result: " + (num1 + num2));
                        break;

                    case 2:
                        Console.Write("Enter first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Result: " + (num1 - num2));
                        break;

                    case 3:
                        Console.Write("Enter first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Result: " + (num1 * num2));
                        break;

                    case 4:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            } while (choice != 4);
        }
    }
}





