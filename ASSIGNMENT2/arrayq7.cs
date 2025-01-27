using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003.ASSIGNMENT2
{
    internal class arrayq7
    {
        public static  void Main(string[] args)
        {
            int[] array = { 12, 23, 34, 45, 56, 67, 78 };
            int[] evenArray = new int[array.Length];
            int[] oddArray = new int[array.Length];
            int evenIndex = 0, oddIndex = 0;

            // Separate odd and even
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    evenArray[evenIndex++] = array[i];
                else
                    oddArray[oddIndex++] = array[i];
            }

            Console.WriteLine("Even elements:");
            for (int i = 0; i < evenIndex; i++) Console.WriteLine(evenArray[i]);

            Console.WriteLine("Odd elements:");
            for (int i = 0; i < oddIndex; i++) Console.WriteLine(oddArray[i]);
        }
    }
}
