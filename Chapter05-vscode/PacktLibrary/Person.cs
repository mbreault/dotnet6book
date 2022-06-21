using System;
using static System.Console;
using System.Collections.Generic;
namespace Packt.Shared
{
    public class Person
    {
        public Person()
        {
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        public readonly DateTime Instantiated;
        public const string Species = "Homo Sapiens";
        public readonly string HomePlanet = "Earth";
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
        public WondersOfTheAncientWorld FavoriteAncientWonder;

        // methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }
        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }
        public (string Name, int Number) GetFruit()
        {
            return (Name: "Apples", Number: 5);
        }
        // deconstructors
        public void Deconstruct(out string name, out DateTime dob)
        {
            name = Name;
            dob = DateOfBirth;
        }
        public void Deconstruct(out string name,
          out DateTime dob, out WondersOfTheAncientWorld fav)
        {
            name = Name;
            dob = DateOfBirth;
            fav = FavoriteAncientWonder;
        }
        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }
        public string SayHelloTo(string name)
        {
            return $"{Name} says 'Hello {name}!'";
        }
        public string OptionalParameters(string command = "Run!", double number = 0.0, bool active = true)
        {
            return string.Format(
              format: "command is {0}, number is {1}, active is {2}",
              arg0: command,
              arg1: number,
              arg2: active);
        }
        public void PassingParameters(int x, ref int y, out int z)
        {
            // out parameters cannot have a default
            // AND must be initialized inside the method
            z = 99;
            // increment each parameter
            x++;
            y++;
            z++;
        }
    }
}