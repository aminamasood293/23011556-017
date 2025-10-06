using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_017
{
    internal class Class5
    {
        public void table()
        {
            Console.WriteLine("enter a Number ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                //Console.WriteLine($"{num} * {i} = {num*i}");
                Console.WriteLine(num + " x " + i + "  =  " + num * i);
            }

        }
    }
}
