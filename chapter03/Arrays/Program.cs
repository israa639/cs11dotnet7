string[] names = new[] { "Kate", "Jack", "Rebecca", "Tom" };

for (int i = 0; i < names.Length; i++)
{
    
    WriteLine(names[i]);
}

string[,] grid1 = new[,] // two dimensions
{
 { "Alpha", "Beta", "Gamma", "Delta" },
 { "Anne", "Ben", "Charlie", "Doug" },
 { "Aardvark", "Bear", "Cat", "Dog" }
};

for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
    for (int col = 0; col <= grid1.GetUpperBound(1); col++)
    {
        WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
    }
}


string[][] jagged = new string[3][]; jagged[0] = new string[] { "alpha", "beta" };