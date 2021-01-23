using System;
using System.IO;
using System.Xml;

namespace different_types
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------- Boolean Type -------------------
            bool happy_ = true;
            bool sad_ = false;

            // ----------------------- Storing any type of object ------------------
            /*
                There is a special type named object that can store any type of data, but its flexibility comes
                at the cost of messier code and possibly poor performance. Because of those two reasons, you
                should avoid it whenever possible.
            */

            object height = 1.88; // storing a double in an object
            object name = "Amir"; // storing a string in an object
            Console.WriteLine($"{name} is {height} metres tall.");
            //int length1 = name.Length; // gives compile error!
            int length2 = ((string)name).Length; // tell compiler it is a string
            Console.WriteLine($"{name} has {length2} characters.");


            // ------------------------- Storing dynamic types -------------------
            /*
                There is another special type named dynamic that can also store any type of data, but even
                more than object, its flexibility comes at the cost of performance. The dynamic keyword was
                introduced in C# 4.0. However, unlike object, the value stored in the variable can have its
                members invoked without an explicit cast. Let's make use of a dynamic type:
            */

            // storing a string in a dynamic object
            dynamic anotherName = "Ahmed";
            // this compiles but would throw an exception at run-time
            // if you later store a data type that does not have a
            // property named Length
            int length = anotherName.Length;
            Console.WriteLine(length);

            // -------------------- var ----------------------
            /*
            Good Practice: Although using var is convenient, some developers avoid
            using it, to make it easier for a code reader to understand the types in use.
            Personally, I use it only when the type is obvious. For example, in the
            following code statements, the first statement is just as clear as the second
            in stating what the type of the xml variable is, but it is shorter. However, the
            third statement isn't clear, so the fourth is better. If in doubt, spell it out!
            */
            var population = 66_000_000; // 66 million in UK
            var weight = 1.88; // in kilograms
            var price = 4.99M; // in pounds sterling
            var fruit = "Apples"; // strings use double-quotes
            var letter = 'Z'; // chars use single-quotes
            var happy = true; // Booleans have value of true or false
            // read more in basic/var
            // example 
            // good use of var because it avoids the repeated type
            // as shown in the more verbose second statement
            var xml1 = new XmlDocument();
            XmlDocument xml2 = new XmlDocument();
            // bad use of var because we cannot tell the type, so we
            // should use a specific type declaration as shown in
            // the second statement
            //var file1 = File.CreateText(@"C:\something.txt"); 
            //StreamWriter file2 = File.CreateText(@"C:\something.txt");

            // -------------------------- Using target-typed new to instantiate objects -----------
            /*
            With C# 9, Microsoft introduced another syntax for instantiating objects known as target-typed
            new. When instantiating an object, you can specify the type first and then use new without
            repeating the type
            */
            XmlDocument xml3 = new(); // target-typed new in C# 9

            // -------------------- Storing multiple values Array ------------------
            /*
            Arrays are always of a fixed size at the time of memory allocation, so you need to decide how
            many items you want to store before instantiating them.
            */
            string[] names; // can reference any array of strings
            // allocating memory for four strings in an array
            names = new string[4];
            // notes
            // Arrays are useful for temporarily storing multiple items, but collections are a more flexible
            // option when adding and removing items dynamically.

            // --------------- Making a value type nullable -------------------
            /*
            By default, value types like int and DateTime must always have a value, hence their name.
            Sometimes, for example, when reading values stored in a database that allows empty,
            missing, or null values, it is convenient to allow a value type to be null. We call this
            a nullable value type.
            */
            int thisCannotBeNull = 4;
            // thisCannotBeNull = null; // compile error!
            int? thisCouldBeNull = null;
            Console.WriteLine("Null Value ----------------------");
            Console.WriteLine(thisCouldBeNull); // null
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault()); // 0
            Console.WriteLine("int Value ----------------------");
            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull); // 7
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault()); // 7
        }
    }
}
