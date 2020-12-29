using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class VD11
    {
        static void Main11(string[] args)
        {
            string[] students = new string[3] { "jame", "alex", "phong" };
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
            Console.ReadKey();
        }
    }
}
