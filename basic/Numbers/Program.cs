using System;

namespace Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------- Types Numbers -------------------//
            // unsigned integer means positive whole number
            // including 0
            uint naturalNumber = 23;

            // integer means negative or positive whole number
            // including 0
            int integerNumber = -23;

            // float means single-precision floating point
            // F suffix makes it a float literal
            float realNumber = 2.3F;

            // double means double-precision floating point
            double anotherRealNumber = 2.3; // double literal


            // ---------------------------------- Comparing double and decimal types ----------------
            //Never compare double values using ==.
            Console.WriteLine("Using doubles:");
            double a = 0.1;
            double b = 0.2;
            Console.WriteLine(a + b); // 0.30000000000000004
            if (a + b == 0.3)
            {
            Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
            Console.WriteLine($"{a} + {b} does NOT equal 0.3");
            }
            // result 0.1 + 0.2 does NOT equal 0.3
                // ---------------- fix compare double ----------------
            Console.WriteLine("Using decimals:");
            decimal c = 0.1M; // M suffix means a decimal literal value
            decimal d = 0.2M;
            Console.WriteLine(a + b);
            if (c + d == 0.3M)
            {
            Console.WriteLine($"{c} + {d} equals 0.3");
            }
            else
            {
            Console.WriteLine($"{c} + {d} does NOT equal 0.3");
            }
        }
    }
}
