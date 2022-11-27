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

            calculationSumAndAVG();
            Console.WriteLine("........................................................................................................................");

            //Task2 call
            Console.WriteLine("The Cube Of Number is : " + Cube());
            Console.WriteLine("........................................................................................................................");

            //Task3 call
            Years();
            Console.WriteLine("........................................................................................................................");

            //Task4 call
            Console.WriteLine("Your Age in Days is: " + Days());
            Console.WriteLine("........................................................................................................................");

            //Task5 call
            Console.WriteLine("Numbers Of Animals Legs is: " + Legs());
            Console.WriteLine("........................................................................................................................");

            //Task6 call
            Console.WriteLine(login());
            Console.WriteLine("........................................................................................................................");

            //Task7 call
            Console.WriteLine("The Power Of Number is : " + Power());
            Console.WriteLine("........................................................................................................................");

            //Task8 call
            Leapyear();
            Console.WriteLine("........................................................................................................................");

            //Task9 call
            Prime();
            Console.WriteLine("........................................................................................................................");

           //Task10 call
            Sentence();
            Console.WriteLine("........................................................................................................................");
        }

        //Task1 code 

        static public void calculationSumAndAVG()
        {
            Console.WriteLine("Task 1");
            Console.WriteLine();
            Console.WriteLine("Enter 10 Numbers to find SUM and AVG Please :))");
            Console.WriteLine();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter Number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];

            }
            Console.WriteLine("the sumation of numbers is : " + sum);
            Console.WriteLine("the AVG of numbers is : " + sum / numbers.Length);
        }


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

        //Task3 code

        static void Years()
        {
            Console.WriteLine("Task3");
            Console.WriteLine();
            int [] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            foreach (int year in years)
            {
                if (year > 1950) 
                Console.WriteLine( year + " is greater than 1950");
            }
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

        //Task5 code

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

        //Task6 code

        static public string login()
        {
            Console.WriteLine( "Task 6");
            Console.WriteLine();
            Console.WriteLine("Enter your email please: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your pasword please: ");
            string password = Console.ReadLine();

            string[] emails = { "nsreen@gmail.com", "nouran@gmail.com", "rogina@gmail.com", "razan@gmail.com", "lubna@gmail.com" };
            string[] passwords = { "1234", "123", "12345", "1111" , "2525"};
            for (int i = 0; i < emails.Length; i++)
            {
                if (email == emails[i] && password == passwords[i])
                {
                    return "pass";
                }
            }

            return "fail";
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

        //Task8 code

        static void Leapyear()
        {
            Console.WriteLine("Task8");
            Console.WriteLine();
            Console.Write("Enter year between 1900-2024: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                Console.WriteLine( year + " is a Leap Year ");
            else
                Console.WriteLine( year + " isn't a Leap Year ");
        }

        //Task 9 code 
        static public void Prime()
        {

            Console.WriteLine("Task 9");
            Console.WriteLine();
            Console.WriteLine("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(number + " is not prime number");
                    return;
                }
            }
            Console.WriteLine(number + " is a prime number");
        }

        //Task 10
        static public void Sentence()

        {
            Console.WriteLine("Task 10");
            Console.WriteLine();
            Console.WriteLine("Write a sentence here to return the number of words: ");
            string sentence= Console.ReadLine();
            string[] s = sentence.Split(new char[] { });
            Console.WriteLine(s.Length);

        }
    }
}