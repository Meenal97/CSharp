using System;
using System.Security.Cryptography.X509Certificates;

namespace ReportCardApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter number of Students");
            number = Convert.ToInt32(Console.ReadLine());
            string[] name = new string[number];
            int[,] marks = new int[number, 3];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter name of student {0} ", i);
                name[i] = Console.ReadLine();
                for(int j=0; j < 3;j++)
                {
                    Console.Write("Marks in Subject {0} {1}   ", i, j);
                    marks[i,j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            Console.WriteLine("Data -----------------------------  ");
            /* Data */
            for (int i = 0; i < number; i++)
            {
                int sum = 0;
                float avg = 0.0f;
                Console.WriteLine(name[i]);
                for(int j=0;j<3;j++)
                {
                    Console.Write("Marks in Subject {0}{1} ", i,j);
                    Console.WriteLine( marks[i,j]);
                    sum += marks[i, j];
                }
                Console.WriteLine("Sum {0} ", sum);
                avg = sum / 3;
                Console.WriteLine("Average {0} ", avg);
            }
        }
    }
}
