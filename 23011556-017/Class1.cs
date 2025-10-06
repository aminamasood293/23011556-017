using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenodd
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ete be");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even ");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
