
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62.Genericsss
{
    class Base<data1, data2>
    {
        data1 id;
        data2 name;

        public Base(data1 i, data2 n)
        {
            id = i;
            name = n;
        }

        internal void Display()
        {
            Console.WriteLine("\nValue 1 : " + id);
            Console.WriteLine("Value 2 : " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base<int, string> b = new Base<int, string>(121, "Jaydeep");
            b.Display();

            Base<string, double> c = new Base<string, double>("Jack ", 47500);
            c.Display();

            Console.Read();

        }
    }
}
