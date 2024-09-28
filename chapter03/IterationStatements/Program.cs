int x = 0;
while (x < 10)
{
    WriteLine(x);
    x++;
}

string[] names = { "Adam", "Barry", "Charlie" };
foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}