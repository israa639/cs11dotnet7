using Packt.Shared;
Person bob = new(); 
WriteLine(bob.DateOfBirth);
bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22); // C# 1.0 or later
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
 arg0: bob.Name,
 arg1: bob.DateOfBirth);
Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new(1998, 3, 7) // C# 9.0 or later
};
WriteLine(format: "{0} was born on {1:dd MMM yy}",
 arg0: alice.Name,
 arg1: alice.DateOfBirth);


bob.FavoriteAncientWonder =
 WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
WriteLine(
 format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
 arg0: bob.Name,
 arg1: bob.FavoriteAncientWonder,
 arg2: (int)bob.FavoriteAncientWonder);
bob.WriteToConsole();
WriteLine(bob.GetOrigin());




Passenger[] passengers = {
 new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
 new FirstClassPassenger { AirMiles = 16_562, Name = "Lucy" },
 new BusinessClassPassenger { Name = "Janice" },
 new CoachClassPassenger { CarryOnKG = 25.7, Name = "Dave" },
  new CoachClassPassenger { CarryOnKG = 0, Name = "Amit" },
};
foreach (Passenger passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
        FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
        FirstClassPassenger _ => 2000M,
        BusinessClassPassenger _ => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 650M,
        _ => 800M
    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}