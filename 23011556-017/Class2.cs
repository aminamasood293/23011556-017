using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class Class2
    {
        //static void Main(string[] args)
        //  {
        public void calc()
        {
            Console.WriteLine("1st num");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2nd num");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("for add press 1 \nfor sub press 2\nfor mul press 3\nfor div press 4");
            int opp = Convert.ToInt32(Console.ReadLine());
            switch (opp)
            {
                case 1:

                    {
                        Console.WriteLine($"{num1 + num2}");
                    }
                    break;
                case 2:

                    {
                        Console.WriteLine($"{num1 - num2}");
                    }
                    break;
                case 3:

                    {
                        Console.WriteLine($"{num1 * num2}");
                    }
                    break;
                case 4:

                    {
                        if (num2 == 0)
                        {
                            Console.WriteLine("the number is not divisible");
                        }
                        else { Console.WriteLine($"{num1 / num2}"); }

                    }
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }

        }
        //}
    }
}


