using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDemo
{
    class printarray
    {
        public static void ToPrint(int[] inputarray)
        {

            foreach (int element in inputarray)
            {
                Console.WriteLine("elements:" + element);
            }
            Console.WriteLine("-------");

        }

    }
}

