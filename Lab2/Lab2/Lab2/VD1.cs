using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class VD1
    {
        static void Main1(string[] args)
        {
            int n = 3;
            double salary = 1500;
            int bonus = 0;
            if(n < 5)
            {
                if(salary < 500)
                {
                    bonus = 100;
                }
                else
                {
                    bonus = 200;
                }
            }
            else
            {
                bonus = 700;
            }
            Console.WriteLine("Bonus amount : " + bonus);
            Console.ReadKey();
        }
    }
}
