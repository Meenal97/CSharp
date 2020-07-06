using System;
using System.Collections.Generic;
using System.Text;

namespace Name
{
    public class Polymorphism
    {
        public string firstName = "FN";
        public string lastName = "LN";

        public virtual void printClass()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }


    public class permanentEmployee : Polymorphism
    {
        public override void printClass()
        {
            Console.WriteLine(firstName + " " + lastName + " - Permanent");
        }
    }

    public class fullEmployee : Polymorphism
    {
        public override void printClass()
        {
            Console.WriteLine(firstName + " " + lastName + " - Full Time");
        }
    }

    public class tempEmployee : Polymorphism
    {
        public override void printClass()
        {
            Console.WriteLine(firstName + " " + lastName + " - Temporary Employee");
        }
    }
}
