﻿using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

namespace Packt.Shared;
public class Person :object, IComparable<Person?>
{
    // properties
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public event EventHandler? Shout;
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }


    public int AngerLevel;
    // method
    public void Poke()
    {
        AngerLevel++;
        if (AngerLevel >= 3)
        {
            // if something is listening...
            if (Shout != null)
                Shout(this, EventArgs.Empty);
        }
    }

    public int CompareTo(Person? other)
    {
        int position;
        if ((this is not null) && (other is not null))
        {
            if ((Name is not null) && (other.Name is not null))
            {
                
                 position = Name.CompareTo(other.Name);
            }
            else if ((Name is not null) && (other.Name is null))
            {
                position = -1; // else this Person precedes other Person
            }
            else if ((Name is null) && (other.Name is not null))
            {
                position = 1; // else this Person follows other Person
            }
            else
            {
                position = 0; // this Person and other Person are at same position
            }
        }
        else if ((this is not null) && (other is null))
        {
            position = -1; // this Person precedes other Person
        }
        else if ((this is null) && (other is not null))
        {
            position = 1; // this Person follows other Person
        }
        else
        {
            position = 0; // this Person and other Person are at same position
        }
        return position;
    }
}
