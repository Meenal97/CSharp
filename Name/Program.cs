﻿using System;


namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name");
            string str = Console.ReadLine();

            Console.WriteLine("What is your name");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hell0 {0}, You're {1} ", str, age);


            Datatype.datatypes();

            Datatype d = new Datatype();
            d.datatype2();
        
        }



       
    }
}
