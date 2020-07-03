using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Name
{
    class Datatype
    {
        public static void  datatypes()
        {
            Console.WriteLine("Integer Max: {0} ", Int32.MaxValue);
            Console.WriteLine("Integer Max: {0} ", Int32.MinValue);
        }

        public void datatype2()
        {
            Console.WriteLine("Float Max: {0} ", float.MaxValue);
            Console.WriteLine("Float Max: {0} ", float.MinValue);
            Name();
        }

        static void Name()
        {
            Console.WriteLine("My name is \'Meenal\' ");
        }



    }
}
