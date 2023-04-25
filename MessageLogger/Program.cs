using MessageLogger;
using System;
using System.Collections.Generic;
Console.WriteLine("Welcome to Message Logger!\n");
DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);
TimeOnly timeOnly = TimeOnly.FromDateTime(DateTime.Now);
var userInput = "";
Console.WriteLine("Lets create a user profile for you.");
Console.Write("What is your name?");
Console.ReadLine();
Console.Write("What is your username? (one word, no spaces!)");
Console.ReadLine();
Console.WriteLine("\n");
Console.WriteLine("To log out of your user profile, enter 'log out'.");
User user1 = new ("");
user1.LogIn();


var messages = new List<string>();




Console.Write("Add a message (or 'quit' to exit): " );
userInput = Console.ReadLine();
Console.WriteLine(timeOnly + ": " + userInput + "\n");
messages.Add(userInput);



while (userInput != "quit")
{
    Console.Write("Add a message: ", "\n");
    userInput = Console.ReadLine();
    Console.WriteLine(timeOnly + ": " + userInput + "\n");
    //string logMessage = String.Format("[{0}]", timeOnly);
    // Console.WriteLine(logMessage);

    foreach(var message in messages)
    {
        Console.WriteLine(timeOnly + ": " + message + "\n");
    }
    messages.Add(userInput);
}

   

if (userInput == "quit")
{
    Console.WriteLine($"Thanks for using Message Logger! During this session, you logged {messages.Count} messages");
}
else if (userInput == "log out")
{
    Console.Write("Would you like to log in 'new' or 'existing' user?");
}







