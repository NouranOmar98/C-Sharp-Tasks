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
        Console.WriteLine("The Cube Of Number is : " + Cube());
        Console.WriteLine("........................................................................................................................");
        Console.WriteLine(Getmax(2,5));
        }
        

        static int Cube()
        {
            Console.WriteLine("Task1");
            Console.WriteLine();
            Console.Write("Enter Number to Cube It: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = number * number * number;
            return result;
        }

        static int Getmax(int num1, int num2)
        {
            //Console.Write("Enter num1: ");
            //int num1=Convert.ToInt32 (Console.ReadLine());
            //Console.Write("Enter num2: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                return num1;

            }
            else
            {
                return num2;
            }

         



        }
    }
}
