using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnMoreThanOneValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int total = 0, product = 0;
            Calculate(a, b,out  total,out  product);

            Console.WriteLine("Total = {0} and Product = {1} ", total, product);
            int[] Numbers = new int[3];

            Numbers[0] = 100;
            Numbers[1] = 101;
            Numbers[2] = 102;

            ParamsMethod(Numbers);
            Console.ReadKey();


           
        }
        public static void Calculate(int a,int b,out int sum,out int product)
        {
            sum = a + b;
            product = a * b;
        }

        public static void ParamsMethod(int[] Numbers)
        {
            Console.WriteLine("Length: {0} " ,Numbers.Length);
            foreach(int i in Numbers)
            {
                Console.WriteLine(i *  2);
            }
        }
    }
}
