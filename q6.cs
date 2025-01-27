using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003
{
    internal class q6
    {
        public static void Main(string[] args)
        {
            int no = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(no++);
                    
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }

    }
}
