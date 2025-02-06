using Lib.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lib.Data
{
    public static class BookDataBase
    {

        public static List<Book> books = new List<Book> 
        {
            new Book("Книга",300,"Книжный","Кто-то")
        };

        public static List<Book> GetBookBase()
        {
            return books;
        }


        public static void AddBook(Book book)
        {
            books.Add(book);
        }

        // можно и через LINQ но торопился )
        public static void EditBook(Book book,string name, int pages, string genre, string publ)
        {
            books.Remove(book);
            books.Add(new Book(name,pages,genre,publ));
        }

        public static void DeleteBook(Book book)
        {
            books.Remove(book);
        }

    }
}
