﻿using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ExpectionsINCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamreader = null;
            try
            {
                streamreader = new StreamReader(@"C:\Users\Meenal\Documents\sample\Hello.txt");
                Console.WriteLine(streamreader.ReadToEnd());
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("File {0} not found", ex.FileName);
                Console.WriteLine();
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if(streamreader != null)
                {
                    streamreader.Close();
                }
                Console.WriteLine("Finally Executed");
            }
        }
    }
}
