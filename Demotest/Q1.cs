using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003.Demotest
{
     class Q1
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Student erno : ");
            string erno= Console.ReadLine();

            Console.Write("Enter Student Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Student City: ");
            string city = Console.ReadLine();

            Console.WriteLine("\nStudent Details:");
            
            Console.WriteLine("student name is : " + name);
            Console.WriteLine("enrollment number is : " + erno);
            Console.WriteLine("age  is : " + age);
            Console.WriteLine("city is : " + city);

        }
    }
}
