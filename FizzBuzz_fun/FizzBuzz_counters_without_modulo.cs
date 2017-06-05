using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_fun
{
    class FizzBuzz_counters_without_modulo
    {
        public static void Execute()
        {
            int mod_three = 0;
            int mod_five = 0;  

            for (int i = 1; i <= 100; i++)
            {
                mod_three++;
                mod_five++;

                if (mod_three == 3)
                    mod_three = 0;
                if (mod_five == 5)
                    mod_five = 0;

                if (mod_three == 0)
                    Console.Write("Fizz");
                if (mod_five == 0)
                    Console.Write("Buzz");
                if (mod_three > 0 && mod_five > 0)
                    Console.Write(i);

                Console.WriteLine();
            }
        }


    }
}
