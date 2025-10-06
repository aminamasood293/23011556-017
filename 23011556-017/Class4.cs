using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_017
{
    internal class Class4
    {
        public void series_sum()
        {
            //static void Main(string[] args)
            //{
            int sum = 0;
            Console.WriteLine("enter a Number ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {

                sum = sum + i;

            }
            Console.WriteLine($"The sum is:{sum} ");
        }
        }
   // }
}
