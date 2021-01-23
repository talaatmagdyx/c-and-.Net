using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;
            Console.WriteLine(
            format: "{0} apples costs {1:C}",
            arg0: numberOfApples,
            arg1: pricePerApple * numberOfApples);
            string formatted = string.Format(
            format: "{0} apples costs {1:C}",
            arg0: numberOfApples,
            arg1: pricePerApple * numberOfApples);
            //WriteToFile(formatted); // writes the string into a file

            // ---------------- Formatting using interpolated strings ---------------------
            /*
                C# 6.0 and later has a handy feature named interpolated strings. A string prefixed with $ can
                use curly braces around the name of a variable or expression to output the current value of that
                variable or expression at that position in the string
            */
            Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");
        }
    }
}
