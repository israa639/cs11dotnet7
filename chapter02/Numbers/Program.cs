uint naturalNumber = 23;

int integerNumber = -23;

float realNumber = 2.3F;

double anotherRealNumber = 2.3;


int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

{
    double x = 0.1, y = 0.2;
    Console.WriteLine($"{x+y == 0.3}");
}
{ 
decimal x = 0.1M, y = 0.2M;
Console.WriteLine($"{x+y == 0.3M}");}