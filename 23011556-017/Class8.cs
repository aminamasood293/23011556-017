using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_017
{
    internal class Class8
    {
        public void maxmin()
        {
            //static void Main(string[] args)
            //{
            Console.WriteLine("enter 10 Numbers ");

            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = arr[0];
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("max is " + max);

            int min = arr[0];
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] < min)

                {
                    min = arr[i];

                }
            }
            Console.WriteLine("min is " + min);
        }
        //}
    }
}
