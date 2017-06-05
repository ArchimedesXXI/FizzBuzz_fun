using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_fun
{
    class FizzBuzz_switch
    {
        public static void Execute()
        {
            for(int i = 1; i <= 100; i++)
            {
                int mod_15 = i % 15;

                switch(mod_15)
                {
                    case 0:
                        Console.WriteLine("FizzBuzz");
                        break;
                    case 3:
                    case 6:
                    case 9:
                    case 12:
                        Console.WriteLine("Fizz");
                        break;
                    case 5:
                    case 10:
                        Console.WriteLine("Buzz");
                        break;
                    default:
                        Console.WriteLine(i);
                        break;
                }
            }
        }


    }
}
