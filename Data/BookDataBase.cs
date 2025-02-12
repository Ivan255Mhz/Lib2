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
            new Book("Книга 1", 300, "Фантастика", "Издатель А"),
            new Book("Книга 2", 250, "Детектив", "Издатель Б"),
            new Book("Книга 3", 400, "Роман", "Издатель В"),
            new Book("Книга 4", 320, "Научная литература", "Издатель Г"),
            new Book("Книга 5", 280, "История", "Издатель Д"),
            new Book("Книга 6", 350, "Биография", "Издатель Е"),
            new Book("Книга 7", 200, "Поэзия", "Издатель Ж"),
            new Book("Книга 8", 450, "Фэнтези", "Издатель З"),
            new Book("Книга 9", 300, "Триллер", "Издатель И"),
            new Book("Книга 10", 270, "Драма", "Издатель К"),
            new Book("Книга 11", 310, "Комедия", "Издатель Л"),
            new Book("Книга 12", 290, "Ужасы", "Издатель М"),
            new Book("Книга 13", 330, "Приключения", "Издатель Н"),
            new Book("Книга 14", 260, "Мистика", "Издатель О"),
            new Book("Книга 15", 380, "Научная фантастика", "Издатель П")
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
