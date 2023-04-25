Console.WriteLine("Welcome to Message Logger!\n");
DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);
TimeOnly timeOnly = TimeOnly.FromDateTime(DateTime.Now);
var userInput = "";
Message 

Console.Write($"Add a message (or 'quit' to exit): " );
Console.WriteLine(timeOnly + ": " + Console.ReadLine());
var messages = new List<string>();
{

}
while (userInput != "quit")
{
    Console.Write("Add a message: ");
    userInput = Console.ReadLine();
    Console.WriteLine(timeOnly + ": " + userInput);
    Console.WriteLine("\n");
    
}
if (userInput == "quit")
{
    Console.WriteLine($"Thanks for using Message Logger! During this session, you logged {messages.Count} messages");
}





