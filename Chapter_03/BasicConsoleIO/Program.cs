using System;

Console.WriteLine("***** Basic Console I/O *****");
GetUserData();
Console.ReadLine();

static void GetUserData()
{
    Console.Write("Please enter your name: ");
    string userName = Console.ReadLine();
    Console.Write("Please enter your age: ");
    string userAge = Console.ReadLine();

    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine("Hello {0}! You are {1} years old.", userName,userAge);

    Console.ForegroundColor = prevColor;
}