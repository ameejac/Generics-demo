using System;
using System.Collections.Generic;

namespace GenericDemo
{
    class Program
    {


        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            new printarray<int>(intArray).toprint();
            new printarray<double>(doubleArray).toprint();
            new printarray<char>(charArray).toprint();
        }

    }
}
