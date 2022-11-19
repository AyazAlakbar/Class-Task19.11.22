using System;
using System.Collections.Generic;
using System.Text;

namespace h.w19._11._22_Class
{
    internal class Account
    {
        public string Username;
        public string Password;


        public Account()
        {

        }

        public  Account(string username, string password)
        {
            Username= username;
            Password=password;

        }
        public string Enter()
        {
            if ((Username == "cavid123") && (Password == "Cavid1993"))
            {
                return $"Login success";
            }

            else
                return $"Wrong";
            {

            }
            return $"{Username} {Password}";
        }

            
        
           
                
        
       
        
	

	}

    
    
}
