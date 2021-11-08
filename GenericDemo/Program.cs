using System;
using System.Collections.Generic;

namespace GenericDemo
{
    class Program
    {
        public static void toprint<T>(T[] inputarray)
        {
            foreach (var element in inputarray)
            {
                Console.WriteLine("elements:" + element);
            }
            Console.WriteLine("-------");
        }

        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Program.toprint<int>(intArray);
            Program.toprint<double>(doubleArray);
            Program.toprint<char>(charArray);
        }

    }
}
