using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003
{
    internal class arrayq2
    {
        public static void Main(String[] arg)
        {

            int[] ary = new int[7];
            Console.WriteLine("Enter 7 array elements:");

            // Input array elements
            for (int i = 0; i < ary.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                ary[i] = int.Parse(Console.ReadLine());
            }

            // Sorting the array using nested loops
            for (int i = 0; i < ary.Length; i++)
            {
                for (int j = i + 1; j < ary.Length; j++)
                {
                    if (ary[i] > ary[j])
                    {
                        // Swap elements
                        int temp = ary[i];
                        ary[i] = ary[j];
                        ary[j] = temp;
                    }
                }
            }

            Console.WriteLine("\nSorted elements are:");
            for (int i = 0; i < ary.Length; i++)
            {
                Console.WriteLine(ary[i]);
            }
        }
    }
}