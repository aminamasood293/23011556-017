using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countt
{
    internal class Class9
    {
        public void count()
        {
            //static void Main(string[] args)
            //{
            Console.WriteLine("enter 10 Numbers ");

            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int even = 0;
            int odd = 0;
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("no of even inputs " + even);
            Console.WriteLine("no of odd inputs " + odd);

        }
    //}
    
}
}
