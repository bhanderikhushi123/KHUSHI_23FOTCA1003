using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003
{
    internal class arrayq3
    {
        public static void Main(String [] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine($"Enter {n} integers:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array in reverse order:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
