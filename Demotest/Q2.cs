using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003.Demotest
{
    internal class Q2
    {
        public static void Main(string[] args)
        {
            int a, b, temp;

            Console.Write("Enter first number: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            b = int.Parse(Console.ReadLine());

            
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("\nAfter swapping:");
            Console.WriteLine("First number: " + a);
            Console.WriteLine("Second number: " + b);
        }
    }
}
