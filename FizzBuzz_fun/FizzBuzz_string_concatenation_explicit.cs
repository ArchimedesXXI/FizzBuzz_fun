using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_fun
{
    class FizzBuzz_string_concatenation_explicit
    {
        public static void Execute()
        {
            for (int i = 1; i <= 100; i++)
            {
                string s = "";
                bool divisibleBy3 = (i % 3 == 0);
                bool divisibleBy5 = (i % 5 == 0);

                if (divisibleBy3 || divisibleBy5)
                {
                    if (divisibleBy3)
                        s = s + "Fizz";
                    if (divisibleBy5)
                        s = s + "Buzz";
                }
                else
                    s = i.ToString();
                Console.WriteLine(s);
            }
        }


    }
}
