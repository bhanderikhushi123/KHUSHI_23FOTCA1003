using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003
{
    internal class q9
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the number (Table to be calculated): ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The multiplication table of {0} is:", num);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", num, i, num * i);
            }
        }
    }
}
