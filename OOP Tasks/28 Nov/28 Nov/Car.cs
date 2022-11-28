using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Nov
{
    internal class Car
    {
        private string country;
        private string year;
        private string type;
        private double price;
        private string model;
        private string palletno;
        private string color;

        public Car(string country, string year, string type, double price, string model, string palletno, string color)
        {
            this.country = country;
            this.year = year;
            this.type = type;
            this.price = price;
            this.model = model;
            this.palletno = palletno;
            this.color = color;
        }

        public string Country { get => country; set => country = value; }
        public string Year { get => year; set => year = value; }
        public string Type { get => type; set => type = value; }
        public double Price { get => price; set => price = value; }
        public string Model { get => model; set => model = value; }
        public string Palletno { get => palletno; set => palletno = value; }
        public string Color { get => color; set => color = value; }

        public void start()
        {
            Console.WriteLine("On");
        }
        public void stop()
        {
            Console.WriteLine("Off");
        }
    }
    class child : Car
    {
        public child(string country, string year, string type, double price, string model, string palletno, string color):base(country,  year,  type,  price,  model,  palletno,  color)
        {
        }
        public void distance( int L)
        {
            int dis = L * 20;
            Console.WriteLine(dis);

        }
    }
}
