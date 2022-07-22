using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.Private_Access
{
    class MyClass
    {
        int a;

        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        

    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m.A = 10;

            Console.WriteLine("Private Variable Value : {0}",m.A);
           




            Console.Read();
        }
    }
}
