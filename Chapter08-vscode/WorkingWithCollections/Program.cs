﻿using static System.Console;
using System.Collections.Immutable;

WorkingWithLists();
WorkingWithDictionaries();
WorkingWithQueues();
WorkingWithPriorityQueues();

static void Output(string title, IEnumerable<string> collection)
{
    WriteLine(title);
    foreach (string item in collection)
    {
        WriteLine($"  {item}");
    }
}

static void WorkingWithLists()
{
    // Simple syntax for creating a list and adding three items
    List<string> cities = new();
    cities.Add("London");
    cities.Add("Paris");
    cities.Add("Milan");
    /* Alternative syntax that is converted by the compiler into
       the three Add method calls above
    List<string> cities = new()
      { "London", "Paris", "Milan" };
    */
    /* Alternative syntax that passes an 
       array of string values to AddRange method
    List<string> cities = new(); 
    cities.AddRange(new[] { "London", "Paris", "Milan" });
    */
    Output("Initial list", cities);
    WriteLine($"The first city is {cities[0]}.");
    WriteLine($"The last city is {cities[cities.Count - 1]}.");

    cities.Insert(0, "Sydney");
    Output("After inserting Sydney at index 0", cities);
    cities.RemoveAt(1);
    cities.Remove("Milan");
    Output("After removing two cities", cities);

    ImmutableList<string> immutableCities = cities.ToImmutableList();
    ImmutableList<string> newList = immutableCities.Add("Rio");
    Output("Immutable list of cities:", immutableCities);
    Output("New list of cities:", newList);
}

static void WorkingWithDictionaries()
{
    Dictionary<string, string> keywords = new();
    // add using named parameters
    keywords.Add(key: "int", value: "32-bit integer data type");
    // add using positional parameters
    keywords.Add("long", "64-bit integer data type");
    keywords.Add("float", "Single precision floating point number");
    Output("Dictionary keys:", keywords.Keys);
    Output("Dictionary values:", keywords.Values);
    WriteLine("Keywords and their definitions");
    foreach (KeyValuePair<string, string> item in keywords)
    {
        WriteLine($"  {item.Key}: {item.Value}");
    }
    // lookup a value using a key
    string key = "long";
    WriteLine($"The definition of {key} is {keywords[key]}");
}

static void WorkingWithQueues()
{
    Queue<string> coffee = new();
    coffee.Enqueue("Damir"); // front of queue
    coffee.Enqueue("Andrea");
    coffee.Enqueue("Ronald");
    coffee.Enqueue("Amin");
    coffee.Enqueue("Irina"); // back of queue
    Output("Initial queue from front to back", coffee);
    // server handles next person in queue
    string served = coffee.Dequeue();
    WriteLine($"Served: {served}.");
    // server handles next person in queue
    served = coffee.Dequeue();
    WriteLine($"Served: {served}.");
    Output("Current queue from front to back", coffee);
    WriteLine($"{coffee.Peek()} is next in line.");
    Output("Current queue from front to back", coffee);
}

static void OutputPQ<TElement, TPriority>(string title, IEnumerable<(TElement, TPriority)> collection)
{
    WriteLine(title);
    foreach ((TElement, TPriority) item in collection)
    {
        WriteLine($"  {item}");
    }
}

static void WorkingWithPriorityQueues()
{
    PriorityQueue<string, int> vaccine = new();
    // add some people
    // 1 = high priority people in their 70s or poor health
    // 2 = medium priority e.g. middle aged
    // 3 = low priority e.g. teens and twenties
    vaccine.Enqueue("Pamela", 1);  // my mum (70s)
    vaccine.Enqueue("Rebecca", 3); // my niece (teens)
    vaccine.Enqueue("Juliet", 2);  // my sister (40s)
    vaccine.Enqueue("Ian", 1);     // my dad (70s)
    OutputPQ("Current queue for vaccination:", vaccine.UnorderedItems);
    WriteLine($"{vaccine.Dequeue()} has been vaccinated.");
    WriteLine($"{vaccine.Dequeue()} has been vaccinated.");
    OutputPQ("Current queue for vaccination:", vaccine.UnorderedItems);
    WriteLine($"{vaccine.Dequeue()} has been vaccinated.");
    vaccine.Enqueue("Mark", 2); // me (40s)
    WriteLine($"{vaccine.Peek()} will be next to be vaccinated.");
    OutputPQ("Current queue for vaccination:", vaccine.UnorderedItems);
}

