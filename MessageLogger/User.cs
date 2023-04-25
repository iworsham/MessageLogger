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
        public List<string> Messages;


        public User (string name, string username)
        {
            Name = name;
            UserName = username;
            LoggedIn = false;
            Messages = new List<string>();
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

    }
}
