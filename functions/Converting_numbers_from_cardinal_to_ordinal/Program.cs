using static System.Console;

/* 
Numbers that are used to count are called cardinal numbers, for example, 1, 2, and 3, whereas
numbers used to order are ordinal numbers, for example, 1st, 2nd, and 3rd
*/
namespace Converting_numbers_from_cardinal_to_ordinal
{
    class Program
    {
        /// <summary>
        /// Pass a 32-bit integer and it will be converted into its ordinal equivalent.
        /// </summary>
        /// <param name="number">Number is a cardinal value e.g. 1, 2, 3, and soon.</param>
        /// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd, and so on.</returns>
        static string CardinalToOrdinal(int number) {
            switch (number)
            {
                case 11: // special cases for 11th to 13th
                case 12:
                case 13:
                return $"{number}th";
                default:
                int lastDigit = number % 10;
                string suffix = lastDigit switch
                {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
                };
                return $"{number}{suffix}";
            }
        }
        static void RunCardinalToOrdinal()
        {
            for (int number = 1; number <= 40; number++)
            {
                Write($"{CardinalToOrdinal(number)} ");
            }
            WriteLine();
        }
        static void Main(string[] args)
        {
            RunCardinalToOrdinal();
        }
    }
}
