using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Class
{
    public class Admin : User
    {

        public override string ToString() =>
            $"Имя: {name} Логин: {login} Учетная запись: {nameof(Admin)}";
        public Admin()
        {
        }

        public Admin(string name, string login, string password)
        {
            this.name = name;
            this.login = login;
            this.password = password;
        }
        
        
    }
}
