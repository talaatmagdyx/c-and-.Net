using System;
using static System.Console;
namespace text_input_from_user
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Type your first name and press ENTER: ");
            string firstName = Console.ReadLine();
            Write("Type your age and press ENTER: ");
            string age = Console.ReadLine();
            WriteLine(
            $"Hello {firstName}, you look good for {age}.");

            Write("Press any key combination: ");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();
            WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
            arg0: key.Key,
            arg1: key.KeyChar,
            arg2: key.Modifiers);
        }
    }
}
