using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_fun
{
    class FizzBuzz_polymorphism
    {
        public static void Execute()
        {
            number[] nums = new number[100];

            for(int i = 1; i <= 100; i++)
            {
                number N = new number(i);

                N = (i % 3 == 0) ? new fizz_number() : N;
                N = (i % 5 == 0) ? new buzz_number() : N;
                N = (i % 15 == 0) ? new fizzbuzz_number() : N;

                nums[i - 1] = N;
            }

            foreach (number n in nums)
                n.writeMe();
        }
    }


    class number
    {
        public number () { }
        public number(int value) { this.value = value; }
        private int value { get; set; }
        public virtual void writeMe() { Console.WriteLine(value); }
    }

    class fizzbuzz_number : number
    {
        public override void writeMe() { Console.WriteLine("FizzBuzz"); }
    }

    class fizz_number : number
    {
        public override void writeMe() { Console.WriteLine("Fizz"); }
    }

    class buzz_number : number
    {
        public override void writeMe() { Console.WriteLine("Buzz"); }
    }
}
