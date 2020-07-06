using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;


namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name");
            string str = Console.ReadLine();

            Console.WriteLine("What is your name");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hell0 {0}, You're {1} ", str, age);


            Datatype.datatypes();

            Datatype d = new Datatype();
            d.datatype2();

            // Nullable types
            int? n = null;
            Console.WriteLine("N : {0}", n);

            int Number;
            Number = n ?? 100;
            Console.WriteLine("N: {0}", Number);


            Armstring a = new Armstring();
            Console.WriteLine(a.ArmstongOrnot(153));

            EvenNumbers e = new EvenNumbers();
            e.Even();
            EvenNumbers.EvenNumber(30);

            int i = 80, k= 80;
            Parameter.SimpleMethod(i);
            Parameter.SimpleMethod2(ref k);
            Console.WriteLine("Pass by value : {0}", i);
            Console.WriteLine("Pass by reference : {0}", k);


            int total = 0;
            int product = 0;
            Parameter.Calculate(10, 20, out total, out product);

            Console.WriteLine("Sum is {0} && Product is {1}", total, product);

            PATA.ClassA.print();
            PATB.ClassA.print();


            Constructers c1 = new Constructers("P","T");
            Constructers c2 = new Constructers();
            c1.FullName();
            c2.FullName();


            StaticAndInstance s1 = new StaticAndInstance(6);
            float area = s1.Area();
            Console.WriteLine("Area is {0} ", area);


            StaticAndInstance s2 = new StaticAndInstance(5);
            float area2 = s2.Area();
            Console.WriteLine("Area is {0} ", area2);
        }


       
       
    }
}
