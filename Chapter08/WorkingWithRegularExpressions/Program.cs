using System.Text.RegularExpressions;
using static System.Console;
Write("Enter your age: ");
string input = ReadLine()!; // null-forgiving
Regex ageChecker = new(@"^[A-Z]{2}\d{3}$");
if (ageChecker.IsMatch(input))
{
    WriteLine("Thank you!");
}
else
{
    WriteLine($"This is not a valid age: {input}");
}


string films = """
"Monsters, Inc.","I, Tonya","Lock, Stock and Two Smoking Barrels"
""";
WriteLine($"Films to split: {films}");
string[] filmsDumb = films.Split(',');
WriteLine("Splitting with string.Split method:");
foreach (string film in filmsDumb)
{
    WriteLine(film);
}