using System;
using static System.Console;
using System.Collections.Generic;
namespace Packt.Shared
{
    public class Person
    {
        public const string Species = "Homo Sapiens";
        public readonly string HomePlanet = "Earth";
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
    }
}