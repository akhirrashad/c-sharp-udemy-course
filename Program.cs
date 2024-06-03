// See https://aka.ms/new-console-template for more information

using System.Resources;

int num = 10;
double price = 19.95;
string name = "Frank";

// Interpolation
Console.WriteLine($"The number is {num}");
// Concatenation
Console.WriteLine("The number is " + num);
// String formatting
Console.WriteLine("This number is {0}", num);

// String formatting with multiple variables
Console.WriteLine("This number is {0}, and the price is {1}. and the name is {2}", num, price, name);