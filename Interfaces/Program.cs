using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomer1
    {
        void Print1();
        void InterfaceMethod();
    }
    interface ICustomer2 : ICustomer1
    {
        void Print2();
        void InterfaceMethod();
    }
    public class Customer : ICustomer2
    {
        public void Print1()
        {
            Console.WriteLine("Print1");
        }

        public void Print2()
        {
            Console.WriteLine("Print2");
        }

        void ICustomer2.InterfaceMethod()
        {
            Console.WriteLine("Interface 1, InterfaceMethod ");
        }

        void ICustomer1.InterfaceMethod()
        {
            Console.WriteLine("Interface 2, InterfaceMethod ");
        }

      
    }
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer1 cust = new Customer();
            cust.Print1();

            Customer c1 = new Customer();
            ((ICustomer1)c1).InterfaceMethod();
            ((ICustomer2)c1).InterfaceMethod();


            Console.ReadKey();
        }
    }
}
