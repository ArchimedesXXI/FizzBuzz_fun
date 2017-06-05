using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_fun
{
    class FizzBuzz_string_concatenation_implicit
    {
        public static void Execute()
        {
            for (int i = 1; i <= 100; i++)
            {
                bool divisibleBy3 = (i % 3 == 0);
                bool divisibleBy5 = (i % 5 == 0);

                if (divisibleBy3 || divisibleBy5)
                {
                    if (divisibleBy3)
                        Console.Write("Fizz");
                    if (divisibleBy5)
                        Console.Write("Buzz");
                }
                else
                    Console.Write(i);
                Console.Write("\n");
            }
        }


    }
}