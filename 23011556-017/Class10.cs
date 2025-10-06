using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linear_search
{
    internal class Class10
    {
        public void search()
        {
            //static void Main(string[] args)
            //  {
            /*input from user
            Console.WriteLine("enter 10 Numbers ");
          
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }*/
            int flag = 0;
            int[] arr = { 2, 55, 80, 75, 100, 234, 22, 77, 65, 12 };
            Console.WriteLine("enter num you want to check");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] == num)
                {
                    flag = 1;
                }

            }
            if (flag == 1)
            {
                Console.WriteLine("number " + num + "  exist");
            }
            else
            {
                Console.WriteLine("number " + num + " does not exist");
            }
        }
        //}
    }
}
