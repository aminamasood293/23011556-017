using evenodd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_017
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 2");
            //no 1
            Console.WriteLine("\n\n\\ttQuestion1");
            Class1 obj1= new Class1();
            obj1.eo();
            //no2
            Console.WriteLine("\n\t\tQuestion1");
            Class2 obj2 = new Class2();
            obj2.calc();
            //no3
            Console.WriteLine("\n\t\tQuestion3");
            Class3 obj3 = new Class3();
            obj3.grades();
            //no4
            Console.WriteLine("\n\t\tQuestion4");
            Class4 obj4 = new Class4();
            obj4.series_sum();
            //no5
            Console.WriteLine("\n\t\tQuestion5");
            Class5 obj5 = new Class5();
            obj5.table();

        }
    }
}
