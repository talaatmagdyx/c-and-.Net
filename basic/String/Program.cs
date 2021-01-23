using System;

namespace basic_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------

            // if need space in string 
            string fullNameWithTabSeparator = "Bob\tSmith"; // \t --> space
            Console.WriteLine(fullNameWithTabSeparator);
            // storing char 
            char letter = 'A'; // assigning literal characters
            
            // -----------------------------------------

            //if you are storing the path to a file, and one of the folder names starts with a T
            // string filePath = "C:\televisions\sony\bravia.txt"; occur --> error Unrecognized escape sequence
            // You must prefix with the @ symbol to use a verbatim literal string,
            //@ to disable escape characters 
            string filePath = @"C:\televisions\sony\bravia.txt";
            Console.WriteLine(filePath);
        }
    }
}
