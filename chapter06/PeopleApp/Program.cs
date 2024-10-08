using Packt.Shared;
Person harry = new()
{
    Name = "Harry",
    DateOfBirth = new(year: 2001, month: 3, day: 25)
};
harry.WriteToConsole();


System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");
int key = 2; // look up the value that has 2 as its key
WriteLine(format: "Key {0} has value: {1}",
 arg0: key,
 arg1: lookupObject[key]);

harry.Shout = Harry_Shout;

harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();