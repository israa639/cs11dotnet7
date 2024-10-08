namespace Packt.Shared;
public class Person : object
{
    // properties
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public EventHandler? Shout;
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
}
