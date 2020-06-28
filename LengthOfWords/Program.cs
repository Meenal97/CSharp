using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LengthOfWords
{
    class Program
    {
        public static void CallMeD()
        {
            Console.WriteLine("A static method");
        }
        public void EvenNumbers(string str)
        {
            string[] words = str.Split(' ');
            foreach(var word in words)
            {
               Console.WriteLine("Word: {0}, Length: {1}", word,word.Length);
            }

        }
        static void Main()
        {
            String str = "Lets see if this works or not";
            Program p = new Program();
            p.EvenNumbers(str);
            CallMeD();
            Program.CallMeD();
            Console.ReadKey();
        }
    }
}
