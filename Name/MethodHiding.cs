using System;
using System.Collections.Generic;
using System.Text;

namespace Name
{
    public class MethodHiding
    {
        public string firstName;
        public string lastName;

        public void printClass()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class PermanentEmployee : MethodHiding
    {
        public new void printClass()
        {
            Console.WriteLine(firstName + " " + lastName + " - Permanent");
        }
    }

    public class PartTimeEmployee : MethodHiding
    {
      
    }

}
