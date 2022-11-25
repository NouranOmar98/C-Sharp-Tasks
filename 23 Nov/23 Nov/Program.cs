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


            //Task1 Call


            //Task2 call
            Console.WriteLine("The Cube Of Number is : " + Cube());
            Console.WriteLine("........................................................................................................................");

            //Task3 call
            Console.WriteLine();

            //Task4 call
            Console.WriteLine( "Your Age in Days is: " + Days());
            Console.WriteLine("........................................................................................................................");
            
            //Task5 call
            Console.WriteLine("Numbers Of Lags is: " + Legs());
            Console.WriteLine("........................................................................................................................");

            //Task7 call
            Console.WriteLine("The Power Of Number is : " + Power());
            Console.WriteLine("........................................................................................................................");


        }

        //Task1 code 



        //Task2 code

        static int Cube()
        {
            Console.WriteLine("Task1");
            Console.WriteLine();
            Console.Write("Enter Number to Cube It: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = number * number * number;
            return result;
        }

        //Task4 code 

        static int Days()
        {

            Console.WriteLine("Task4");
            Console.WriteLine();
            Console.Write("Enter Your Age in Years: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int ageindays = age * 365;
            return ageindays;
        }

        //Task5

        static int Legs()
        {
            Console.WriteLine("Task5");
            Console.WriteLine();
            Console.Write("Enter Numbers of Chicken: ");
            int Chicken = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Numbers of Cow: ");
            int Cow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Numbers of Pigs: ");
            int Pigs = Convert.ToInt32(Console.ReadLine());
            int Legs = (Chicken * 2) + (Pigs * 4) + (Cow * 4);
            return Legs;
        }

        //Task7 code

        static int Power()
        {
            Console.WriteLine("Task7");
            Console.WriteLine();
            Console.Write("Enter Number to Calc Power: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int result1 = number1 * number1;
            return result1;
        }


    }
}