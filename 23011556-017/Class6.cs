using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact
{
    
    internal class Class6
    {
        public void factorial()
        {
            Console.WriteLine("enter a Number ");
         int num = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
         if (num == 0 || num == 1)
         {
             Console.WriteLine("factorial is 1 ");
         }
         else
         {
             int i = 1;
             while (i <= num)
             {
                 fact = fact* i;
    i++;
             }
Console.WriteLine("The factorial is:" + fact);
             //Console.WriteLine($"factorial is {fact}");
         }
}}}