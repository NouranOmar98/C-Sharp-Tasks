using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Nov
{
    internal class PersonInformation
    {

        private int age;
        private string ginder;
        private string name;
        private string email;
        private int id;
        private string phonenumber;

        public PersonInformation(int age, string ginder, string name, string email, int id, string phonenumber)
        {
            this.age = age;
            if (age < 18 || age > 60)
            {
                Console.WriteLine("This age is between 18-60");
            }
            else
            {
                this.age = age;
            }
            this.ginder = ginder;
            this.name = name;
            this.email = email;
            this.id = id;

            this.phonenumber = phonenumber;

            if (phonenumber.Substring(0, 3) == "077" || phonenumber.Substring(0, 3) == "078" || phonenumber.Substring(0, 3) == "079")
            {
                this.phonenumber = phonenumber;

            }
            else
            {
                Console.WriteLine("Please Enter right number");
            }
        }
        static void Main(string[] args)
        {
            PersonInformation Nouran = new PersonInformation(24, "Femail", "Nouran", "nouranomar@gmail.com", 998200260, "0777077777");

            Console.WriteLine(" Hello Guys! My Name is " + Nouran.name);
            Console.WriteLine(" I am " + Nouran.age + " Years Old " + Nouran.ginder);
            Console.WriteLine(" I am Jordainian So I have a national Id and this is it : " + Nouran.id);
            Console.WriteLine(" You can find me in: " + Nouran.email);
            Console.WriteLine(" and this is my phone number if you want another way to contact! " + Nouran.phonenumber);
        }
    }
}
