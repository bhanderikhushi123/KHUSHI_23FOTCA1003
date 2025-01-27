using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003
{
    internal class q11
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;

            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine("{0} is a prime number.", num);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number.", num);
            }
        }
     
    }
}
