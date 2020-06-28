using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMax
{   
    class MaxFinder
    {
        public int FindMax(int num1,int num2)
        {
            int result;
            result = (num1 > num2) ? num1 : num2;
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            MaxFinder m = new MaxFinder();
            int  res = m.FindMax(a, b);
            Console.WriteLine("MAX Value is : {0}", res);

            Console.ReadLine();
        }
    }
}
