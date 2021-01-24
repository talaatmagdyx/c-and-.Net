using System;
using System.Collections.Generic;
namespace Packt.Shared
{
    public class Person
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
