﻿using System;

namespace CountOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "11441155";
            char[] strArray = str.ToCharArray();
            int count = 0;
            for(int s=0; s < strArray.Length ; s++)
            {
                 if(strArray[s] == '1')
                { 
                    count++;
                }
               
            }
           Console.WriteLine("One of one {0} ", count);
        }
    }
}
