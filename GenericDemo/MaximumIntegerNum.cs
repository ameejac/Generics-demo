using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDemo
{
    class MaximumIntegerNum
    {
        public static int MaxNum(int firstvalue, int seccondvalue, int thirdvalue)
        {
            if (firstvalue.CompareTo(seccondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;
            }
            else if (seccondvalue.CompareTo(firstvalue) > 0 && seccondvalue.CompareTo(thirdvalue) > 0)
            {
                return seccondvalue;
            }
            else if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(seccondvalue) > 0)
            {
                return thirdvalue;
            }
            else
            {
                Console.WriteLine(" two are more values are equal");
                return 0;
            }
        }
    }
}