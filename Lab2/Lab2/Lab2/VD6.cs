using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class VD6
    {
        static void Main6(string[] args)
        {
            int r = 2;
            int c = 2;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("{0}", i * j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
