using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Class
{
    public class User
    {
        //public static int id {  get; set; }

        public string name { get; set; }

        public string login { get; set; }

        public string password { get; set; }

        public override string ToString() =>
            $"Имя: {name} Логин: {login}";

        public User()
        {
        }

        public User(string name, string login, string password)
        {
            this.name = name;
            this.login = login;
            this.password = password;
        }
    }
}
