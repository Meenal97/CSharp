using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHidingVsMethodOrverding
{
    public class Employee
    {
        public void Print()
        {
            Console.WriteLine("I am in Base class");
        }
        public virtual void Hello()
        {
            Console.WriteLine("Hello, I am in Base class");
        }
    }


    public class PartTimeEmployee : Employee
    {
        public new void Print()
        {
            Console.WriteLine("I am in Derived class");
        }

        public override void Hello()
        {
            Console.WriteLine("Hello, I am in Derived class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.Print();
            PTE.Hello();

            Console.WriteLine("________________________________________________________");

            Employee E = new PartTimeEmployee();
            E.Print();
            E.Hello();

            Console.ReadKey();
        }
    }
}
