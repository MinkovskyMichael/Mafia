using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mafia.Models
{
    public class UserModel
    {
        string username;
        int userId;

        public UserModel(string username, int userId)
        {
            Username = username;
            UserId = userId;
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public int UserId
        {
            get
            {
                return userId;
            }

            set
            {
                userId = value;
            }
        }
    }
}