using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003.ASSIGNMENT2
{
    internal class arrayq6
    {
        public static  void Main(string[] args)
        {
                int[] array = { 15, 42, 7, 23, 89, 34 };

                int max = array[0];
                int min = array[0];

                // Finding maximum and minimum
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max) max = array[i];
                    if (array[i] < min) min = array[i];
                }

                Console.WriteLine($"Maximum element: {max}");
                Console.WriteLine($"Minimum element: {min}");
            
        }
    }
}
