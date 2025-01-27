using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003
{
    internal class pattern
    {
        public static void Main(string[] args)
        {
            int rows = 4; // Number of rows in the pyramid
            int number = 1; // Starting number

            // Loop for each row
            for (int i = 1; i <= rows; i++)
            {
                // Printing leading spaces for alignment
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                // Printing numbers in each row
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++; // Increment the number
                }

                // Move to the next line after each row
                Console.WriteLine();
            }
        }
    }
}
