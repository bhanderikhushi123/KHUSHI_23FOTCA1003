using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003.ASSIGNMENT2
{
    internal class arrayq8
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] odd = Array.FindAll(arr, n => n % 2 != 0);
            int[] even = Array.FindAll(arr, n => n % 2 == 0);

            Console.WriteLine("Odd Numbers: " + string.Join(", ", odd));
            Console.WriteLine("Even Numbers: " + string.Join(", ", even));
        }
    }
}
