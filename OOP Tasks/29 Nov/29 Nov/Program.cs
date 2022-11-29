using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nov29
{
    class Employee
    {

        public string employee_name { get; set; }
        public int employee_id { get; set; }
        public int birth_date { get; set; }

        public Employee()
        {
        }

        //constructor Employee
        public Employee(string name, int id, int BDate)
        {
            employee_name = name;
            employee_id = id;
            birth_date = BDate;

        }
        //age method
        public void print(int age)
        {
            birth_date = 2022 - age;
            Console.WriteLine($"The Employee name : {birth_date} ");


        }



        // method to print full information 
        public void print()
        {
            Console.WriteLine($"The Employee name : {employee_name} ");
            Console.WriteLine($"the Employee ID : {employee_id}");
            //Console.WriteLine($" the birth date  : {birth_date} ");

        }
        //inhertance class
        class Manager : Employee
        {
        }

        internal class Test
        {


            static void Main(string[] args)
            {


                Console.Write("Please Enter the Employee Mame : ");
                string emp_name = Console.ReadLine();

                Console.Write("Please Enter the Employee ID : ");
                int emp_id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please Enter your Birth Year: ");
                int birth_date = Convert.ToInt32(Console.ReadLine());

                Employee employee = new Employee(emp_name, emp_id, birth_date);
                employee.print();
                employee.print(birth_date);


            }
        }
    }
}