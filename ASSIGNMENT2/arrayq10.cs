using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003.ASSIGNMENT2
{
    internal class arrayq10
    {
        public static void Main(string[] args)
        {
            int[] array = { 10, 20, 30, 40, 50 };
            int size = array.Length;

            Console.Write("Enter the position (1-5) to delete: ");
            int position = int.Parse(Console.ReadLine()) - 1;

            if (position >= 0 && position < size)
            {
                for (int i = position; i < size - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                size--; // Reduce size after deletion

                Console.WriteLine("Array after deletion:");
                for (int i = 0; i < size; i++) Console.WriteLine(array[i]);
            }
            else
            {
                Console.WriteLine("Invalid position!");
            }
        }
    }
}
