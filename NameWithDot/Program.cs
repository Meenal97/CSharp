using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace NameWithDot
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Vangipurapu Venkata Sai Laxman";
            string[] words = phrase.Split(' ');

             for(int i=0; i< words.Length;i++)
            {
                char[] ch = words[i].ToCharArray();
                Console.Write(ch[0] + ". ");
            }
            Console.Write(words[words.Length - 1]);
            Console.ReadKey();
        }
    }
}
