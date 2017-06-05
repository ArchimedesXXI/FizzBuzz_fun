using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_fun
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz_classic.Execute();
            FizzBuzz_precalculated_bool.Execute();
            FizzBuzz_string_concatenation_implicit.Execute();
            FizzBuzz_string_concatenation_explicit.Execute();
            FizzBuzz_string_builder.Execute();
            FizzBuzz_counters_without_modulo.Execute();
            FizzBuzz_Hash_table.Execute();
            FizzBuzz_Hash_set.Execute();
            FizzBuzz_ternary_conditional_operator.Execute();
            FizzBuzz_polymorphism.Execute();
            FizzBuzz_switch.Execute();
        }
    }
}
