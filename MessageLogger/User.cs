using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLogger
{
    public class User
    {
        public string Name;
        public string UserName;
        public bool LoggedIn;
        public List<Message> Messages;
        // public string Password;


        public User(string name, string username)
        {
            Name = name;
            UserName = username;
            LoggedIn = false;
            Messages = new List<Message>();
        }
        public string LogIn()
        {
            LoggedIn = true;

            return " Logged In";
        }

        public void LogOut()
        {
            LoggedIn = false;
        }
        public void LoginAgain()
        {
            if (LoggedIn == true)
            {
                Console.WriteLine("Welcome Back");
            }

        }
         public void SaveMessage(Message message)
        {
            Console.WriteLine(message);
        }
    }
}
