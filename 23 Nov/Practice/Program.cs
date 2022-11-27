using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            task1();
            task2();
            task3();
            task4();
            task5();
        

        }

        static void task1()
        {
            Console.Write("Enter num1: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            double result = num1 + num2;
            Console.WriteLine( result);
        }
        static void task2()
        {
            Console.Write("Enter num1: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            double result = num1 * num2;
            Console.WriteLine(result);
        }
        static void task3()
        {
            Console.Write("Enter num1: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            double result = num1 - num2;
            Console.WriteLine(result);
        }
        static void task4()
        {
            Console.Write("Enter num1: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            double result = num1 /  num2;
            Console.WriteLine(result);
        }

        static void task5()
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine( " Welcome " + name );
        }

    }
}
