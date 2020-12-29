using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class VD13
    {
        static void Main(string[] args)
        {
            string[] classOne = { "alan", "chris", "phong" };
            string[] classTwo = { "ba", "bon", "nam" };
            Console.WriteLine("Student of class I: \tStudents of class II:");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(classOne[i] + "\t\t\t" + classTwo[i]);
            }
            classTwo = classOne;
            Console.WriteLine("\nStudent of class II after refenrencing Class I:");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(classTwo[i] + "");
            }
            Console.WriteLine();
            classTwo[2] = "mike";
            Console.WriteLine("Student of class I after changing the third student in class II:");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(classOne[i] + "");
            }
            Console.ReadLine();
        }
    }
}
