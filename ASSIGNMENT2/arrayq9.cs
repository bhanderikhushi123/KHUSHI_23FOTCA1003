using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003.ASSIGNMENT2
{
    internal class arrayq9
    {
        public static void Main(string[] args)
        {
            int[] array = { 23, 12, 45, 34, 67 };

            // Sorting in descending order
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine("Array in descending order:");
            for (int i = 0; i < array.Length; i++) Console.WriteLine(array[i]);
        }
    }
}
