using static System.Console;

List<string> cities = new()
 { "London", "Paris", "Milan" };
Output("Initial list", cities);
WriteLine($"The first city is {cities[0]}.");
WriteLine($"The last city is {cities[cities.Count - 1]}.");
cities.Insert(0, "Sydney");
Output("After inserting Sydney at index 0", cities);
cities.RemoveAt(1);
cities.Remove("Milan");
Output("After removing two cities", cities);

Dictionary<string, string> keywords = new()
{
 { "int", "32-bit integer data type" },
 { "long", "64-bit integer data type" },
 { "float", "Single precision floating point number" },
};

Output("Dictionary keys:", keywords.Keys);
Output("Dictionary values:", keywords.Values);
WriteLine("Keywords and their definitions");
foreach (KeyValuePair<string, string> item in keywords)
{
    WriteLine($" {item.Key}: {item.Value}");
}
// look up a value using a key
string key = "long";
WriteLine($"The definition of {key} is {keywords[key]}");

PriorityQueue<string, int> vaccine = new();

vaccine.Enqueue("Pamela", 1); // my mum (70s)
vaccine.Enqueue("Rebecca", 3); // my niece (teens)
vaccine.Enqueue("Juliet", 2); // my sister (40s)
vaccine.Enqueue("Ian", 1); // my dad (70s)
OutputPQ("Current queue for vaccination:", vaccine.UnorderedItems);
WriteLine($"{vaccine.Dequeue()} has been vaccinated.");
WriteLine($"{vaccine.Dequeue()} has been vaccinated.");
OutputPQ("Current queue for vaccination:", vaccine.UnorderedItems);
WriteLine($"{vaccine.Dequeue()} has been vaccinated.");
WriteLine("Adding Mark to queue with priority 2");
vaccine.Enqueue("Mark", 2); // me (40s)
WriteLine($"{vaccine.Peek()} will be next to be vaccinated.");
OutputPQ("Current queue for vaccination:", vaccine.UnorderedItems);