using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_017
{
    internal class Class3
    {
        public void grades()
        {
            //static void Main(string[] args)
            //{
            Console.WriteLine("enter your marks ");
            int grades = Convert.ToInt32(Console.ReadLine());
            if (grades >= 85)
            {
                Console.WriteLine("your grade is 'A' ");
            }
            else if (grades >= 70 && grades <= 84)
            {
                Console.WriteLine("your grade is 'B' ");
            }
            else if (grades >= 55 && grades <= 69)
            {
                Console.WriteLine("your grade is 'C' ");
            }
            else if (grades >= 40 && grades <= 54)
            {
                Console.WriteLine("your grade is 'D' ");
            }
            else if (grades < 40)
            {
                Console.WriteLine("your grade is 'F' ");
            }
            else
            {
                Console.WriteLine("Invalid input ");
            }
        }
    }
}
