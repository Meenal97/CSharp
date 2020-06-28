using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfRectangle
{
     class Recatangle
    {
        double length;
        double width;

        public void AcceptDetails()
        {
            length = 7.8;
            width = 6.7;
        }

        public double Area()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length {0}", length);
            Console.WriteLine("Width {0}", width);
            Console.WriteLine("Area {0}", Area());
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Recatangle r = new Recatangle();
            r.AcceptDetails();
            r.Display();
            Console.ReadLine();
        }
    }
}
