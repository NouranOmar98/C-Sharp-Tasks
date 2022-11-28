using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Nov
{
    internal class program
    {
       
        static void Main(string[] args)
        {
            //string country, string year, string type, double price, string model, string palletno, string color
            Car c = new Car("Jordan", "2015", "Hybrid", 1000, "Audi", "1222", "Red") ;

            Console.WriteLine("Task 1");
            Console.WriteLine();
            Console.WriteLine(c.Country);
            Console.WriteLine(c.Year);
            Console.WriteLine(c.Type );
            Console.WriteLine(c.Price);
            Console.WriteLine(c.Model);
            Console.WriteLine(c.Palletno);
            Console.WriteLine(c.Color);
          
            c.stop();
          
            Console.WriteLine();
            
            child a = new child("Yemen", "2018", "Hybrid", 5000, "Kia", "1555", "Black");

            Console.WriteLine(c.Country);
            Console.WriteLine(c.Year);
            Console.WriteLine(c.Type);
            Console.WriteLine(c.Price);
            Console.WriteLine(c.Model);
            Console.WriteLine(c.Palletno);
            Console.WriteLine(c.Color);

            c.start();

            Console.WriteLine();

            Console.WriteLine("Task 2");
            Console.WriteLine();
            Console.Write("Inter Num Of Letters: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Results= ");
            a.distance( l);

        }

    }
}
