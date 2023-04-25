using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLogger
{
    public class Message
    {
        public string Content;
        public DateTime CreatedAt;


        public Message (string content)
        {
            Content = content;
            CreatedAt = DateTime.Now;
        }

        public void SaveMessage(string message)
        {
            Console.WriteLine(message);
        }  
        
        //public void loopMessage()
        //{
        //    while (userInput != "quit")
        //    {
        //        Console.Write("Add a message: ", "\n");
        //        userInput = Console.ReadLine();
        //        Console.WriteLine(timeOnly + ": " + userInput + "\n");
        //        //string logMessage = String.Format("[{0}]", timeOnly);
        //        // Console.WriteLine(logMessage);

        //        foreach (var message in messages)
        //        {
        //            Console.WriteLine(timeOnly + ": " + message + "\n");
        //        }
        //        messages.Add(userInput);
        //    }

        //}
      

    }
}
