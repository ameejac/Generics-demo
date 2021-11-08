using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDemo
{
    class printarray<T>
    {
        private T[] inputarray;
        public printarray(T[] inputarray)
        {
            this.inputarray = inputarray;
        }
        public void toprint()
        {
            foreach (var element in inputarray)
            {
                Console.WriteLine("elements:" + element);
            }
            Console.WriteLine("-------");
        }
    }
}