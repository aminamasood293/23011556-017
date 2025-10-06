
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
            Console.WriteLine("\n\n\t\tQuestion1__Check if number is even or odd");
            Class1 obj1= new Class1();
            obj1.eo();
            //no2
            Console.WriteLine("\n\t\tQuestion2__Simple Calculator");
            Class2 obj2 = new Class2();
            obj2.calc();
            //no3
            Console.WriteLine("\n\t\tQuestion3__Calculate Grades");
            Class3 obj3 = new Class3();
            obj3.grades();
            //no4
            Console.WriteLine("\n\t\tQuestion4__Calculate sum until num n");
            Class4 obj4 = new Class4();
            obj4.series_sum();
            //no5
            Console.WriteLine("\n\t\tQuestion5__Table Multiplication");
            Class5 obj5 = new Class5();
            obj5.table();
            //no6
            Console.WriteLine("\n\t\tQuestion6__Calculate factorial");
            Class6 obj6 = new Class6();
            obj6.factorial();
            //no7
            Console.WriteLine("\n\t\tQuestion7__Calculate reverse");
            Class7 obj7 = new Class7();
            obj7.reverse();
            //no8
            Console.WriteLine("\n\t\t Question8__Calculate maxmin");
            Class8 obj8 = new Class8();
            obj8.maxmin();
            //no9
            Console.WriteLine("\n\t\tQuestion9__Count no of even and odd input");
            Class9 obj9 = new Class9();
            obj9.count();
            //no10
            Console.WriteLine("\n\t\tQuestion10__Search number in array linearly ");
            Class10 obj10 = new Class10();
            obj10.search();

        }
    }
}
