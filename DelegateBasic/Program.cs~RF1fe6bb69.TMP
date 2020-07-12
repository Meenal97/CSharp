using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBasic
{
    public delegate void HelloFuncDelegate(string strMessage);
    class Program
    {
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
        static void Main(string[] args)
        {
            HelloFuncDelegate del = new HelloFuncDelegate(Hello);
            del("Hello from Delegate");


            Console.ReadKey();
        }
    }
}
