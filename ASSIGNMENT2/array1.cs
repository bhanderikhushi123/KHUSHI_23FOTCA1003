using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003
{
    internal class array1
    {
        public static void Main(String[] args)
        {


            Console.Write("Enter the number of array : ");
            int n = int.Parse(Console.ReadLine());



            int[] ary = new int[n];

            Console.WriteLine($"Enter {n} elements:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                ary[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Element are : ");

            for (int i = 0; i < ary.Length; i++)
            {
                Console.WriteLine(ary[i]);
            }
        }
    }
}
