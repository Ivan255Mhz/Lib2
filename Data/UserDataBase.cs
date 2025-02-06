using Lib.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Data
{
    public static class UserDataBase
    {
        public static List<User> UserBase = new List<User>
        {
            new Admin("ivan","admin","12345"),
            new Worker("vova","1","1")
        };

        public static List<User> GetUserBase() 
        {
            return UserBase;
        }

        public static void AddUser(User user)
        {
            UserBase.Add(user);
        }

       public static void ChangingUser(User user) // надо оптемезировать 
        {
           
            
        }

        public static void DeleteUser(User user)
        {
            UserBase.Remove(user);
        }

    }
}
