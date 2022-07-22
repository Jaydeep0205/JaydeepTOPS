using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.Employee_Details
{
    class Emp
    {

        protected string name;
        public int salary;
        protected string Dept;

        internal void SetData()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n\nEnter Employee Name : ");
                name = Console.ReadLine();

                Console.Write("Enter Salary : ");
                salary = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Department : ");
                Dept = Console.ReadLine();
            }
        }

    }

    class Employee : Emp
    {
        internal void Display()
        {
            Console.WriteLine("\n\n------------------------");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nEmployee Name : " + name);
                Console.WriteLine("Salary : {0}", salary);
                Console.WriteLine("Department : " + Dept);
            }

        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();

            e.SetData();
            e.Display();



            Console.Read();
        }
    }
}
