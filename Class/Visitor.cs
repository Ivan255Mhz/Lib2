using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace Lib.Class
    {
        public class Visitor : User
        {
            public List<Book> userBooks { get; set; } = new List<Book>();

            public override string ToString() =>
               $"Имя: {name} Логин: {login} Учетная запись: {nameof(Visitor)}";

            public Visitor()
            {
                userBooks = new List<Book>(); 
            }

            public void AddBook(Book book)
            {
                userBooks.Add(book);
            }

            public Visitor(string name, string login, string password)
            {
                this.name = name;
                this.login = login;
                this.password = password;
                userBooks = new List<Book>();
            }
        }
    }

