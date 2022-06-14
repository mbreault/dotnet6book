using Packt.Shared;
using static System.Console;
Person bob = new();
bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 2, 1);
bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon
  | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
bob.Children.Add(new Person { Name = "Alfred" });
bob.Children.Add(new Person { Name = "Zoe" });
WriteLine(format: "{0}'s bucket list is {1}.",
  arg0: bob.Name,
  arg1: bob.BucketList);
WriteLine($"{bob.Name} has {bob.Children.Count()} children.");
for (int childIndex = 0; childIndex < bob.Children.Count();childIndex++)
{
    WriteLine($"{bob.Children[childIndex].Name}");
}

    Person alice = new()
    {
        Name = "Alice Jones",
        DateOfBirth = new(1998, 3, 7) // C# 9.0 or later
    };
WriteLine(format: "{0} was born on {1:dd MMM yy}",
  arg0: alice.Name,
  arg1: alice.DateOfBirth);