using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class VD5
    {
        static void Main5(string[] args)
        {
            int i = 0;
            int j;
            while (i <= 5)
            {
                j = 0;
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.ReadLine();
        }
    }
}
