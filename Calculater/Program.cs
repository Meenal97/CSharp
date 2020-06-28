using System;

namespace Calculater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* Calculator ***************");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtract"); 
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Division");

            int a, b, op;
            Console.WriteLine("Enter first number");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type Operation");
            op = Convert.ToInt32(Console.ReadLine());

            switch(op)
            {
                case 1: Console.WriteLine(a + b);
                        break;
                case 2: Console.WriteLine(a - b);
                        break;
                case 3: Console.WriteLine(a * b);
                        break;
                case 4: Console.WriteLine(a + b);
                        break;
                default: Console.WriteLine("Not valid");
                       break;
            }

        }
    }
}
