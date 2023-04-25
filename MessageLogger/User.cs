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
        public bool LoggedIn;


        public User (string name)
        {
            Name = name;
            LoggedIn = false;
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
