using Packt.Shared;
using System;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new Person();
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965, 12, 22);
            // WriteLine(
            // format: "{0} was born on {1:dddd, d MMMM yyyy}",
            // arg0: bob.Name,
            // arg1: bob.DateOfBirth);
            // bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            bob.BucketList =
            WondersOfTheAncientWorld.HangingGardensOfBabylon;
            | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            // WriteLine(format:
            // "{0}'s favorite wonder is {1}. Its integer is {2}.",
            // arg0: bob.Name,
            // arg1: bob.FavoriteAncientWonder,
            // arg2: (int)bob.FavoriteAncientWonder);
            // WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
            bob.Children.Add(new Person { Name = "Alfred" });
            bob.Children.Add(new Person { Name = "Zoe" });
            WriteLine(
            $"{bob.Name} has {bob.Children.Count} children:");
            for (int child = 0; child < bob.Children.Count; child++)
            {
            WriteLine($" {bob.Children[child].Name}");
            }

        }
    }
}
