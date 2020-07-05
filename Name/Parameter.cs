using System;
using System.Collections.Generic;
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
    }
}
