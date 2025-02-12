using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lib.Class
{
    public class Worker:User
    {

        public string Department { get; set; }
        public override string ToString() =>
           $"Имя: {name} Логин: {login} Учетная запись: {nameof(Worker)}";
        public Worker()
        {
        }

        public Worker(string name, string login, string password)
        {
            this.name = name;
            this.login = login;
            this.password = password;
        }

    }
}
