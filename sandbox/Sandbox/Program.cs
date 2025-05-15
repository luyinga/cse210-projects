using System;

/*Console.WriteLine("Hello World! This is the Sandbox Project.");
int number = 5;
int number2 = number + 3;
number = 8;

Console.WriteLine($"My number is {number2}");

Console.Write("What is your favorite color?");
string color = Console.ReadLine();
Console.WriteLine($"My favorite color is {color}");*/

//Conditional statement and variables
Console.Write("Enter number: ");
int valueFromUser = int.Parse(Console.ReadLine());

int x = valueFromUser;
int y = 2;

if (x > y)
{
    Console.WriteLine("Greater");
}
else if (x < y)
{
    Console.WriteLine("Less");
}
else
{
    Console.WriteLine("Greater");
}
