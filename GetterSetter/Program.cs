using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
    public class Student
    {
        private int passMark = 35;
        private int id;
        private string name;

        public int GetMarks()
        {
            return passMark;
        }

        public void SetID(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Throw");
            }
            this.id = id;
        }

        public int GetID()
        {
            return this.id;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be empty");
            }
            this.name = name;
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(name) ? "No Name" : this.name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.SetName("Meenal");
            s1.SetID(100);
            Console.WriteLine("Pass Marks: {0}", s1.GetMarks());
            Console.WriteLine("Name : {0}", s1.GetName());
            Console.WriteLine("ID : {0}",  s1.GetID());
            Console.ReadKey();
        }
    }
}
