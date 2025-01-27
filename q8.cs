using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003
{
    internal class q8
    {
        public static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("The first 10 natural numbers are:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }
            Console.WriteLine("\nThe Sum is: " + sum);
        }
    }
}
