using System;

namespace OOP
{
    // -------------------- Understanding members ------------------------
    // Fields are used to store data. There are also three specialized categories of field
        // ----------------------------  Constant
        // Constant: The data never changes. The compiler literally copies the data into 
        //any code that reads it.
        // ----------------------------  Read-only
        /// Read-only: The data cannot change after the class is instantiated, but the data
        //can be calculated or loaded from an external source at the time of instantiation.
        // ----------------------------  Event
        // Event: The data references one or more methods that you want to execute when
        //something happens, such as clicking on a button, or responding to a request from other code
    // Methods are used to execute statements
        // ----------------------------- Constructor
        // Constructor: The statements execute when you use the new keyword to allocate 
        // memory and instantiate a class.
        // ----------------------------- Property
        // Property: The statements execute when you get or set data. The data is
        //commonly stored in a field but could be stored externally, or calculated at
        //runtime. Properties are the preferred way to encapsulate fields unless the
        //memory address of the field needs to be exposed.
        // ----------------------------Indexer
        // Indexer: The statements execute when you get or set data using array syntax [].
        // ----------------------------Operator
        // Operator: The statements execute when you use an operator like + and / on operands of your type.



        // ------------------------------ inherits ------------------------
        // B inherits from class A
            // A is the base or superclass 
            // B is the derived or subclass
            // public class B : A
        // Person inherits from the System.Object
            // public class Person : System.Object
            // OR public class Person : object


        // ------------------ Understanding access modifiers---------------
        // Part of encapsulation is choosing how visible the members are.
        // Access Modifier                          Description
        // private   Member is accessible inside the type only. This is the default.
        // internal  Member is accessible inside the type and any type in the same assembly.
        // protected Member is accessible inside the type and any type that inherits from the type.
        // public    Member is accessible everywhere.
        // internal protected Member is accessible inside the type, any type in the same assembly, and any
        //type that inherits from the type. Equivalent to a fictional access modifier named internal_or_protected
        //private protected  Member is accessible inside the type or any type that inherits from the type and is in
        //the same assembly. Equivalent to a fictional access modifier named internal_and_
        //protected. This combination is only available with C# 7.2 or later


        // ---------------------- Storing a value using an enum type --------------
            // ------ Description 
            // Sometimes, a value needs to be one of a limited set of options
            // An enum type is a very efficient way of storing one or more choices because, internally, it uses
            //integer values in combination with a lookup table of string descriptions
            // -------------- example 
            // 
            // public enum WondersOfTheAncientWorld
            // {
            //     GreatPyramidOfGiza,
            //     HangingGardensOfBabylon,
            //     StatueOfZeusAtOlympia,
            //     TempleOfArtemisAtEphesus,
            //     MausoleumAtHalicarnassus,
            //     ColossusOfRhodes,
            //     LighthouseOfAlexandria
            // }
            // use it in another class
            // public WondersOfTheAncientWorld FavoriteAncientWonder;
            // ---------------------- notice
            // Good Practice: Use the enum values to store combinations of discrete options.
            // Derive an enum type from byte if there are up to eight options, from ushort
            // if there are up to 16 options, from uint if there are up to 32 options, and from
            // ulong if there are up to 64 options.

        
        // -------------- Storing multiple values using collection ---
        

        // ---- Combining multiple returned values using tuples
            // -------------- old version
                // public class TextAndNumber
                // {
                //     public string Text;
                //     public int Number;
                // }
                // public class Processor
                // {
                //     public TextAndNumber GetTheData()
                //     {
                //         return new TextAndNumber
                //         {
                //             Text = "What's the meaning of life?",
                //             Number = 42
                //         };
                //     }
                // }
            // tuples 
                // public (string, int) GetFruit()
                    // {
                    // return ("Apples", 5);
                    // }
                // call it
                //(string, int) fruit = bob.GetFruit();
                //WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");
            // ------------------- Naming the fields of a tuple
            //public (string Name, int Number) GetNamedFruit()
            // {
            // return (Name: "Apples", Number: 5);
            // }
            // call it 
            //var fruitNamed = bob.GetNamedFruit();
            // WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
