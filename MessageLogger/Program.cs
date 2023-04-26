using MessageLogger;
using System;
using System.Collections.Generic;
Console.WriteLine("Welcome to Message Logger!\n");
DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);
TimeOnly timeOnly = TimeOnly.FromDateTime(DateTime.Now);
var userInput = "";
Console.WriteLine("Lets create a user profile for you.");
Console.Write("What is your name?");
var name = Console.ReadLine();
Console.Write("What is your username? (one word, no spaces!)");
var userName = Console.ReadLine();
Console.WriteLine("\n");
Console.WriteLine("To log out of your user profile, enter 'log out'.");
var users = new List<User>();

var messages = new List<string>();

User user1 = new(name, userName);
user1.LogIn();


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
        Console.WriteLine(timeOnly + ": " + message );
    }
    messages.Add(userInput);

    if (userInput == "log out")
    {
        user1.LogOut();
        Console.Write("Would you like to log in 'new' or 'existing' user?");
    }
    else if (userInput == "existing")
    {

        user1.LogIn();
    }
    else if (userInput == "new")
    {
        Console.WriteLine("Lets create a user profile for you.");
        Console.Write("What is your name?");
        var name2 = Console.ReadLine();
        Console.Write("What is your username? (one word, no spaces!)");
        var userName2 = Console.ReadLine();
        User user2 = new(name2, userName2);
        user2.LogIn();
        var userInput2 = "";
        userInput2 = Console.ReadLine();
        var messages2 = new List<string>();
        foreach(var message in messages2)
        {
            Console.WriteLine(timeOnly + ": " + message);
        }
        messages2.Add(userInput2);
    }
     
    //user1.SaveMessage();
}

   

if (userInput == "quit")
{
    Console.WriteLine($"Thanks for using Message Logger! During this session {user1.Name}  logged {messages.Count} messages");
}





