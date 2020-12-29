using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class VD7
    {
        static void Main7(string[] args)
        {
            Console.WriteLine("Squre \t\tCube");
            for(int i = 1, j = 0; i < 11; i++, j++)
            {
                if ((i % 2) == 0)
                {
                    Console.Write("{0} = {1}\t\t", i, (i * i));
                    Console.Write("{0} = {1}\n", j, (j * j * j));
                }
            }
            Console.Read();
        }
    }
}
