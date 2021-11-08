using System;

namespace GenericDemo
{
    class Program
    {
        public static void toprint(int[] inputarray)
        {
            foreach (int element in inputarray)
            {
                Console.WriteLine("elements:" + element);
            }
            Console.WriteLine("-------");
        }
        public static void toprint(double[] inputarray)
        {
            foreach (double element in inputarray)
            {
                Console.WriteLine("double data type:" + element);
            }
            Console.WriteLine("-------");
        }
        public static void toprint(char[] inputarray)
        {
            foreach (char element in inputarray)
            {
                Console.WriteLine("char data type:" + element);
            }
            Console.WriteLine("-------");
        }
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Program.toprint(intArray);
            Program.toprint(doubleArray);
            Program.toprint(charArray);
        }

    }
}