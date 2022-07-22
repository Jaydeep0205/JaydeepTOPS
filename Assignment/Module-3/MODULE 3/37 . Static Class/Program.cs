using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37.Static_Class
{
    static class MyClass
    {
        static internal void Values()
        {
            Console.WriteLine("\n\n\tThis is Static Class...... \n\tCalling Through Derived Class......");
        }
    }

    class Class1
    {
        internal void GET()
        {
            Console.WriteLine("\n\tThis is Derived Class....Calling\n");
            MyClass.Values();

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            c.GET();

            Console.Read();
        }
    }
}
