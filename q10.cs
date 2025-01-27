using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003
{
    internal class q10
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("The Factorial of {0} is: {1}", num, factorial);
        }
    }
}
