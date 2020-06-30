using System;

namespace AccessSpecifier
{
    class Access
    {
        private int num = 100;
        public int num2 = 200;
        public int Number()
        {
            return num;
        }
        public void Method()
        {
            Console.WriteLine("A public Method");
        }

        public static void Method2()
        {
            Console.WriteLine("A public Method 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Access a = new Access();
            a.Method();
            Access.Method2();
            Console.WriteLine(a.Number());
            Console.WriteLine(a.num2 + 100);
        }
    }
}
