using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_fun
{
    class FizzBuzz_Hash_set
    {
        public static void Execute()
        {
            HashSet<int> Fizzes = new HashSet<int>();
            HashSet<int> Buzzes = new HashSet<int>();
            HashSet<int> FizzBuzzes = new HashSet<int>();

            int a = 0;
            while (a * 3 <= 100)
            {
                a++;
                Fizzes.Add(a * 3);
                Buzzes.Add(a * 5);
                FizzBuzzes.Add(a * 15);
            }

            string s = "";

            for (int i = 1; i <= 100; i++)
            {
                if (FizzBuzzes.Contains(i))
                    s = "FizzBuzz";
                else if (Buzzes.Contains(i))
                    s = "Buzz";
                else if (Fizzes.Contains(i))
                    s = "Fizz";
                else
                    s = i.ToString();

                Console.WriteLine(s);
            }
        }


    }
}
