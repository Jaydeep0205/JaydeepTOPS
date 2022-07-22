using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Student_5_Data
{
    class Student
    {
        int Rollno;
        string Name;
        int std,age;
        double Mo_No;

        public void SetData()
        {
            
            Console.Write("\nEnter Roll No :\t");
            Rollno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name :\t");
            Name = Console.ReadLine();

            Console.Write("Age : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Standard : ");
            std = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Mo. No.\t: ");
            Mo_No = Convert.ToInt64(Console.ReadLine());

        }

        public void DisplayData()
        {
            
            Console.WriteLine("\nRoll No : {0}",Rollno);
            Console.WriteLine("Name : {0}",Name);
            Console.WriteLine("Age : {0}",age);
            Console.WriteLine("Standard : {0}",std);
            Console.WriteLine("Mobile No. : +91-{0}",Mo_No);

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student[] s = new Student[2];
            Console.WriteLine("Enter Students Details : ");
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = new Student();
                s[i].SetData();
            }

            Console.WriteLine("\n\n  ~~~~~ Students Details ~~~~~ \n\n");

            for (int i = 0; i < s.Length; i++)
            {
                s[i].DisplayData();
            }

            Console.Read();
        }
    }
}
