using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class VD2
    {
        static void Main2(string[] args)
        {
            int day = 5;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Enter a number between 1 to 3");
                    break;
            }
            Console.ReadLine(); 
        }
    }
}
