namespace Packt.Shared;
public class Book
{
    // Needs .NET 7 or later as well as C# 11 or later.
    public required string? Isbn { get; set; }
    public required string? Title { get; set; }
    public string? Author { get; set; }
    public int PageCount { get; set; }
}