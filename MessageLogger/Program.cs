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

User user2 = new(name, userName);
user2.LogIn();


User user3 = new(name, userName);
user3.LogIn();


User user4 = new(name, userName);
user4.LogIn();

users.Add(user1);
users.Add(user2);
users.Add(user3);
users.Add(user4);


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
}

   

if (userInput == "quit")
{
    Console.WriteLine($"Thanks for using Message Logger! During this session, you logged {messages.Count} messages");
}
else if (userInput == "log out")
{
    user1.LogOut();
    Console.Write("Would you like to log in 'new' or 'existing' user?");
}
else if (userInput == "existing")
{

    user1.LogIn();
}


}





