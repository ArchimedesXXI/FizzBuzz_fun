using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_fun
{
    class FizzBuzz_precalculated_bool
    {
        public static void Execute()
        {
            for (int i = 1; i <= 100; i++)
            {
                bool divisibleBy3 = (i % 3 == 0);
                bool divisibleBy5 = (i % 5 == 0);

                if (divisibleBy3 && divisibleBy5)
                    Console.WriteLine("FizzBuzz");
                else if (divisibleBy3)
                    Console.WriteLine("Fizz");
                else if (divisibleBy5)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }


    }
}
