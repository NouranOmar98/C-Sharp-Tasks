using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static nov_29.Program;

namespace nov_29
{
    internal class Program
    {
        public class Employee
        {
            public string name;
            public int yearOfBirth;
            public int id;

            public Employee(string name, int yearOfBirth, int id)
            {
                this.name = name;
                this.yearOfBirth = yearOfBirth;
                this.id = id;
            }
            public int age(int yearOfBirth)
            {
                return 2022 - yearOfBirth;
            }
            public virtual void greetings(string name)
            {
                Console.WriteLine("hello" + " " + name);
            }
            public virtual void greet(int id)
            {
                //Console.WriteLine("your id" + " " + id);
            }
        }

        public class Manager : Employee
        {
            public override void greetings(string name)
            {
                Console.WriteLine("hello" + " " + name);
            }
            public Manager(string name, int yearOfBirth, int id) : base(name, yearOfBirth, id)
            {

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Task 1");
            Console.WriteLine();
            Manager manager = new Manager("Nouran", 1998, 99820026);
            Console.WriteLine("My name is " + manager.name + " " + " I am " + manager.age(manager.yearOfBirth) + " Years Old " + " And My Id Is: " + manager.id);
            Console.WriteLine();
        }
    }
}
