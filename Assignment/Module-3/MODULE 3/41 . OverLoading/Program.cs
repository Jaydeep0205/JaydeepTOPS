using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.OverLoading
{
    class MyClass
    {
        internal void Area(double r)
        {
            Console.WriteLine("\nArea Of Circle : {0}", 3.14*r*r);
        }
        internal void Area(int r)
        {
            Console.WriteLine("\nArea Of Square : {0}", r * r);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m.Area(12);
            m.Area(6.5);

            Console.Read();
        }
    }
}
