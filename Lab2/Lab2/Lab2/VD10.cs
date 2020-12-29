using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class VD10
    {
        static void Main10(string[] args)
        {
            int[] count = new int[10];//array is created
            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                count[i] = counter++;//Values are assigned to the elements
                Console.WriteLine("The count value is : " + count[i]);
                //element values are printed
            }
            Console.ReadKey();
        }
    }
}
