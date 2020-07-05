using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Name
{
    class Parameter
    {
        public static void SimpleMethod(int j)
        {
            j = 101;
        }

        public static void SimpleMethod2(ref int j)
        {
            j = 100 + j;
        }

        public static void Calculate(int i,int j,out int Sum,out int Product)
        {
            Sum = i + j;
            Product = i * j;
        }
    }
}
