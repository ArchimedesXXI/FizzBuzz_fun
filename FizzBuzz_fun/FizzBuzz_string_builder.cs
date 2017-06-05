using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_fun
{
    class FizzBuzz_string_builder
    {
        public static void Execute()
        {
            for (int i = 1; i <= 100; i++)
            {
                StringBuilder builder = new StringBuilder();
                bool divisibleBy3 = (i % 3 == 0);
                bool divisibleBy5 = (i % 5 == 0);

                if (divisibleBy3)
                    builder.Append("Fizz");
                if (divisibleBy5)
                    builder.Append("Buzz");
                if (!divisibleBy3 && !divisibleBy5)
                {
                    builder.Clear();
                    builder.Append(i);
                }

                Console.WriteLine(builder.ToString());
            }
        }


    }
}
