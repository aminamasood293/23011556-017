using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_017
{
    internal class Class7
    {
        public void reverse()
        {
            Console.WriteLine("enter a Number ");
         int num = Convert.ToInt32(Console.ReadLine());
        int n = num;
        int rev = 0;
        int digit;
         while (num != 0)
         {
             digit = num % 10;
             rev = (rev* 10) + digit;
             num=num/ 10;
         }
    Console.WriteLine("the number is " + n +" and the reverse is " +rev);
     }
    }
}
