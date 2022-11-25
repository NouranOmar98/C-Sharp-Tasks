using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1 call
            Console.WriteLine("The Cube Of Number is : " + Cube());
            Console.WriteLine("........................................................................................................................");

            //Task2 call
            Console.WriteLine();
        }

        //Task1 code

        static int Cube()
        {
            Console.WriteLine("Task1");
            Console.WriteLine();
            Console.Write("Enter Number to Cube It: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = number * number * number;
            return result;
        }

        //Task2 code 

    }
}