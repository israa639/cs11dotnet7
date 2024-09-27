
int subtotal = 0, salesTax = 0;
var totalPrice = subtotal/*for this item */ + salesTax;

double heightInMetres = 1.88;
Console.WriteLine($"The variable {nameof(heightInMetres)} has the value{heightInMetres}.");


/*string*/




char letter = 'A'; // assigning literal characters
char digit = '1';
char symbol = '$';




string firstName = "Bob"; // assigning literal strings
string lastName = "Smith";
string phoneNumber = "(215) 555-4256";
string horizontalLine = new('-', count: 74);
string grinningEmoji = char.ConvertFromUtf32(0x1F600);
Console.OutputEncoding = System.Text.Encoding.UTF8;

string grinningEmoji2 = char.ConvertFromUtf32(0x1F600);
Console.WriteLine(grinningEmoji2);

Console.WriteLine("Bob\\Smith");

Console.WriteLine(@"C:\televisions\sony\bravia.txt");
Console.WriteLine($$"""
 {
 "phone": "{{phoneNumber}}",
 "age": {{4}},
 "calculation", "{{{1 + 2}}}"
 }
 """);
Console.WriteLine(""""""""""""
 """""""""<person age="50">
 <first_name>Mark</first_name>
 </person>
 """"""""""""
);


