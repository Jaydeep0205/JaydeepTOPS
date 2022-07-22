using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58.Static_Class
{
    static class MyClass
    {
        static internal void Show()
        {
            int a = 10;

            Console.WriteLine("A  : " + a);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
        }
    }
}
