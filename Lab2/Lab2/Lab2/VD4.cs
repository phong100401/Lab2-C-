using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class VD4
    {
        static void Main4(string[] args)
        {
            int num = 1;
            Console.WriteLine("Even Numbers");
            while(num <= 11)
            {
                if ((num%2) == 0)
                {
                    Console.WriteLine(num);
                }
                num = num + 1;
            }
            Console.ReadLine();
        }
    }
}
