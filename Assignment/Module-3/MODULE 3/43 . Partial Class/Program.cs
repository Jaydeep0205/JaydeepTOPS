using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43.Partial_Class
{
    partial class MyClass
    {
        int a;
        internal void SetA()
        {
            a = 26;
            Console.WriteLine("Age : {0}", a);
        }
    }

    partial class MyClass
    {
        protected string Fname;
        protected string Lname;
    }

    partial class MyClass
    {
        internal void GetData()
        {
            Console.Write("Enter First Name : ");
            Fname = Console.ReadLine();
           
            Console.Write("Enter Last Name : ");
            Lname = Console.ReadLine();
            
        }
    }

    partial class MyClass
    {
        internal void AllData()
        {
            Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.WriteLine("Full Name : "+(Fname+Lname));
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m.GetData();
            m.AllData();
            m.SetA();

            Console.Read();

        }
    }
}
