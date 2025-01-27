using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003
{
    internal class q12
    {
          public static void Main()
        {
            // Upper half of the diamond
            for (int i = 1; i <= 5; i++) // for rows
            {
                for (int a = i; a <= 4; a++) // for spaces
                {
                    Console.Write("  ");
                }
                for (int j = 1; j < (i * 2); j++) // for columns
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // Lower half of the diamond
            for (int i = 4; i >= 1; i--) // for rows
            {
                for (int a = i; a <= 4; a++) // for spaces
                {
                    Console.Write("  ");
                }
                for (int j = 1; j < (i * 2); j++) // for columns
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
