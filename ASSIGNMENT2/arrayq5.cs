using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003.ASSIGNMENT2
{
    internal class arrayq5
    {
        public static void Main(string[] args)
        {
            // Define the source array
            int[] sourceArray = new int[5];
            // Define the destination array
            int[] destinationArray = new int[5];

            Console.WriteLine("Enter 5 elements for the source array:");

            // Input elements for the source array
            for (int i = 0; i < sourceArray.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                sourceArray[i] = int.Parse(Console.ReadLine());
            }

            // Manually copying elements from sourceArray to destinationArray
            for (int i = 0; i < sourceArray.Length; i++)
            {
                destinationArray[i] = sourceArray[i];
            }

            // Display source array
            Console.WriteLine("\nSource array elements:");
            for (int i = 0; i < sourceArray.Length; i++)
            {
                Console.WriteLine(sourceArray[i]);
            }

            // Display destination array
            Console.WriteLine("\nDestination array elements:");
            for (int i = 0; i < destinationArray.Length; i++)
            {
                Console.WriteLine(destinationArray[i]);
            }
        }
    }
}
