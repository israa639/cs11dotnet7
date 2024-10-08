using System.Diagnostics.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared;

public class Person
{
   
    public /*required*/ string? Name { get; set; }
    public DateTime DateOfBirth;
    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public readonly string HomePlanet;
    public Person()
    {
        Name = null;
    }
    //[SetsRequiredMembers]
    public Person(string name)
    {
        Name = name;
    }
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }
    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}.";
    }

}
