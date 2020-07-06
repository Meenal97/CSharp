using System;
using System.Collections.Generic;
using System.Text;

namespace Name
{
    class Constructers
    {
        string _first_Name;
        string _last_Name;
        public Constructers() : this("No First Name", "No Last Name Provided")
        {

        }
        public Constructers(string first_name,string last_name)
        {
            _first_Name = first_name;
            _last_Name = last_name;
        }

        public void FullName()
        {
            Console.WriteLine("Fullname is {0}", _first_Name  + " " + _last_Name);
        }
    }
}
