using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59.Virtual_Method
{
    abstract class Base
    {
        virtual internal void Fun()
        {
            Console.WriteLine("Hello.....\nThis is Virtual Function");
        }
    }

    class Derived : Base
    {
        override internal void Fun()
        {
            Console.WriteLine("Hello.....\nThis is Override Function");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Derived();
            b.Fun();

            Console.Read();
        }
    }
}
