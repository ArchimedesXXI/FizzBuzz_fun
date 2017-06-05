using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_fun
{
    class FizzBuzz_Hash_table
    {
        public static void Execute()
        {
            Dictionary<int, string> FBtable = new Dictionary<int, string>();

            int a = 0;
            while (a * 3 <= 100)
            {
                a++;
                FBtable[a * 3] = "Fizz";
            }

            a = 0;
            while (a * 5 <= 100)
            {
                a++;
                FBtable[a * 5] = "Buzz";
            }

            a = 0;
            while (a * 15 <= 100)
            {
                a++;
                FBtable[a * 15] = "FizzBuzz";
            }


            for(int i = 1; i <= 100; i++)
            {
                if (FBtable.ContainsKey(i))
                    Console.WriteLine( FBtable[i] );
                else
                    Console.WriteLine( i );
            }
        }


    }
}
