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
    }
}