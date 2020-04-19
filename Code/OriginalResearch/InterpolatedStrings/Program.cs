using System;

namespace InterpolatedStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1_000;
            Console.WriteLine($"{i + 9, 10:N0}{i + 8, 10:N0}");

            string positional = string.Format("{0, 10:N0}{1, 10:N0}", i + 9, i + 8);
            Console.WriteLine(positional);

            string argsSpecified = string.Format("{0, 10:N0}{1, 10:N0}", arg0:i + 9, arg1:i + 8);
            Console.WriteLine(argsSpecified);

            string mixed = string.Format($"{0, 10:N0}{i+8, 10:N0}", i + 9);
            Console.WriteLine(mixed); // Doesn't actually format with the args.

            string literal = string.Format(@"{0, 10:N0}{1, 10:N0}", i + 9, i + 8);
            Console.WriteLine(literal); // Doesn't actually format with the args.
        }
    }
}
