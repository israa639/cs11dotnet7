object height = 1.88; // storing a double in an object 
object name = "Amir"; // storing a string in an object
Console.WriteLine($"{name} is {height} metres tall.");
//int length1 = name.Length;
int length2 = ((string)name).Length; // tell compiler it is a string
Console.WriteLine($"{name} has {length2} characters.");
dynamic x = 1;
x = "ahmed";
x = 0.3M;


var population = 67_000_000; // 67 million in UK
var weight = 1.88; // in kilograms
var price = 4.99M; // in pounds sterling
var fruit = "Apples"; // strings use double-quotes
var letter = 'Z'; // chars use single-quotes


var happy = true;