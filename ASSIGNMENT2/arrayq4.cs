using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003
{
    internal class arrayq4
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.WriteLine("Copied array:");
            foreach (int num in arr2)
            {
                Console.WriteLine(num);
            }
        }
    }
}
