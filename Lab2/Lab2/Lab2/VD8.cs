using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class VD8
    {
        static void Main8(string[] args)
        {
            byte number = 0;
            while (true)
            {
                byte fact = 1;
                Console.WriteLine("pls enter a number: ");
                number = Convert.ToByte(Console.ReadLine());
                if(number < 0)
                {
                    goto stop;
                }
                for(byte j = number; j > 0; j--)
                {
                    if(j > 4)
                    {
                        goto stop;
                    }
                    fact *= j;
                }
                Console.WriteLine("factorial of {0} is {1}", number, fact);
            }
        stop:
            Console.WriteLine("Exiting the program");
            Console.ReadLine();
        }
    }
}
