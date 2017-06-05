using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_fun
{
    class FizzBuzz_ternary_conditional_operator
    {
        public static void Execute()
        {
            for (int i = 1; i <= 100; i++)
            {
                string s = i.ToString();

                s = (i % 3 == 0) ? "Fizz" : s;
                s = (i % 5 == 0) ? "Buzz" : s;
                s = (i % 15 == 0) ? "FizzBuzz" : s;

                Console.WriteLine(s);
            }
        } 


    }
}
