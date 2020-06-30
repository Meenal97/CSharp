using AccessSpecifier;
using System;

namespace AccessSpecifier
{
     class Access
    {
        private int num = 100;
        public int num2 = 200;
        protected int num3 = 500;
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

    class Child : Access
    {
        public int protected_method()
        {
            return num3;
        }

        public void protected_method2()
        {
            Console.WriteLine("Num: {0}", num3 * 6);
        }
    }

    class Two : Access
    {
        public int protected_method()
        {
            return num2;
        }

        public void protected_method2()
        {
            Console.WriteLine("Num: {0}", num2 * 6);
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

            Child c = new Child();
            Console.WriteLine(c.protected_method());

            c.protected_method();
            c.protected_method2();

            Two t = new Two();
            Console.WriteLine(c.protected_method());

            t.protected_method();
            t.protected_method2();
        }
    }
}



