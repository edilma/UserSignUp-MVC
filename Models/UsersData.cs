using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class UsersData
    {
        private static List<User> myUsers = new List<User>();


        public static List<User> GetAll {
            get
            {
                return myUsers;
            }
        }

        // Add
        public static void Add(User newUser)
        {
            myUsers.Add(newUser);
        }




    }
}
