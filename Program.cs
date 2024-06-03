// See https://aka.ms/new-console-template for more information

using System.Resources;
string myStr = "Hi\r\nHi";
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine("Counter is " + i);
    Console.WriteLine(myStr);
    Thread.Sleep(1000);
}