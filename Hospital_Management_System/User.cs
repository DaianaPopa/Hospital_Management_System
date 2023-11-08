using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal class User
    {
        private string userName;
        private string password;

        public string GetUserName()
        {
            return userName;
        }

        public string GetPassword()
        { 
            return password;
        }

        public void SetUserName(string newUserName)
        { 
            userName = newUserName;
        }

        public void SetPassword(string newPassword)
        {
            if (newPassword.Length > 5 && newPassword.Length < 10)
            {
                password = newPassword;

            }
        }
    }
   
}
