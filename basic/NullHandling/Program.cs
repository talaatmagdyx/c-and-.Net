#nullable enable
using System;

namespace NullHandling
{
    class Address
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // var address = new Address();
            // address.Building = null;
            // address.Street = null;
            // address.City = "London";
            // address.Region = null;

            // ----------------------- Checking for null
            // check that the variable is not null before using it
            if (thisCouldBeNull != null)
            {
                // access a member of thisCouldBeNull
                int length = thisCouldBeNull.Length; // could throw exception
            
            }

            // If you are trying to use a member of a variable that might be null, use the null-conditional
            // operator ?., as shown in the following code:
            string authorName = null;
            // the following throws a NullReferenceException
            int x = authorName.Length;
            // instead of throwing an exception, null is assigned to y
            int? y = authorName?.Length;


            /*
                Sometimes you want to either assign a variable to a result or use an alternative value, such as
                3, if the variable is null. You do this using the null-coalescing operator, ??
            */
            // result will be 3 if authorName?.Length is null
            var result = authorName?.Length ?? 3;
            Console.WriteLine(result);
        }
    }
}
