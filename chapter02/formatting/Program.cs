using static System.Console;
int numberOfApples = 12;
decimal pricePerApple = 0.35M;
WriteLine(format: "{0} apples cost {1:C}",
                 arg0: numberOfApples,
                 arg1: pricePerApple * numberOfApples);
string formatted = string.Format(format: "{0} apples cost {1:C}",
                 arg0: numberOfApples,
                 arg1: pricePerApple * numberOfApples);




 const string firstname = "Omar";
 const string lastname = "Rudberg";
 string fullname = firstname + " " + lastname;

Console.WriteLine($"{firstname}{lastname}");
string? nullString=Console.ReadLine();
string x = nullString!;
Console.WriteLine($"{nullString}{lastname}");
