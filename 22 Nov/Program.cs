using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Nov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1

            Console.WriteLine("Task1");
            Console.WriteLine();
            Console.WriteLine("First Section");
            int[] ARR = { 1, 7, 9, 45 };
            Console.WriteLine(ARR[0] + " " + ARR[1] + " " + ARR[2] + " " + ARR[3]);
            Console.WriteLine("Second Section");
            string[] arr2 = { "Str", "alex", "moh" };
            Console.WriteLine(arr2[0] + " " + arr2[1] + " " + arr2[2]);
            Console.WriteLine("Third Section");
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };
            Console.WriteLine(arr3[0] + " " + arr3[1] + " " + arr3[2] + " " + arr3[3] + " " + arr3[4]);
            Console.WriteLine("...........................................................................................");

            //Task2

            Console.WriteLine("Task2");
            Console.WriteLine();
            Console.WriteLine("What the index of \"Banana\",\"Tomato\"?\r\n");
            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            int index1 = Array.IndexOf(fruits, "Banana");
            Console.WriteLine("The index of Banana is:" + index1);
            int index2 = Array.IndexOf(fruits, "Watermelon");
            Console.WriteLine("The index of Watermelon is:" + index2);
            Console.WriteLine("...........................................................................................");

            //Task3

            Console.WriteLine("Task3");
            Console.WriteLine();
            String[] foods = { "Mansaf", "Botato", "Mansaf", "Kabseh", "Mango" };
            String[] Sports = { "swime", "Fotball", "basketball" };
            String[] Movies = { "The boss", "fast", "Sandrella", "Snowwhite" };

            Console.WriteLine("Foods");
            foreach (String food in foods) {
                Console.Write(food+" "); }
            Console.WriteLine();
            Console.WriteLine("Sports");
            foreach (String sport in Sports)
            {
                Console.Write(sport+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Movies");
            foreach (String movie in Movies)
            {
                Console.Write(movie+" ");
            }
            Console.WriteLine();
            Console.WriteLine("...........................................................................................");
            //Task4

            Console.WriteLine("Task4");
            Console.WriteLine();

            Console.WriteLine("...........................................................................................");
            //Task6

            Console.WriteLine("Task6");
            Console.WriteLine();
            for (int j = 0; j <= 3; j++)
            {

                for (int i = 0; i <= j; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("...........................................................................................");

            //Task7

            Console.WriteLine("Task7");
            Console.WriteLine();
            int n = 1;
            for (int j = 0; j <= 3; j++)
            {

                for (int i = 0; i <= j; i++)
                {
                    Console.Write(n++);
                }
                Console.WriteLine();
            }












        }
    }
}
