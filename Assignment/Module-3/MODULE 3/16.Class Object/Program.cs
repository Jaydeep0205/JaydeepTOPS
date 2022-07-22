using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Class_Object
{
    class MyClass
    {
        internal void ShowData()
        {
            Console.WriteLine("Class is Calling.......");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m.ShowData();

            Console.Read();
        }
    }
}
