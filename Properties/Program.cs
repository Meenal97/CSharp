using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Student
    {
        private int id;
        private int passMarks = 35;
        private string name;
       
        public string Name
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("No");
                }
                this.name = value;
            }
            get
            {
               return string.IsNullOrEmpty(this.name) ? "No Name" : this.name;
            }
        }
        public int PassMarks
        {
            get
            {
                return this.passMarks;
            }
        }
        public int ID
        {
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Not");
                }
                this.id = value;
            }

            get
            {
                return this.id;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.ID = 101;
           s1.Name = "Meenal";
            Console.WriteLine("Pass Marks: {0} ", s1.PassMarks);
            Console.WriteLine("ID: {0} ", s1.ID);
            Console.WriteLine("Name: {0} ", s1.Name);
            Console.ReadKey();
        }
    }
}
