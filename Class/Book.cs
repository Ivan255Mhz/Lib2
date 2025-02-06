using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lib.Class
{
    public class Book
    {
        public string name {  get; set; }

        public int pages { get; set; }  

        public string genre { get; set; }

        public string publisher { get; set; }

        public Book()
        {

        }

        public Book(string name, int pages, string genre, string publisher)
        {
            this.name = name;
            this.pages = pages;
            this.genre = genre;
            this.publisher = publisher;
        }


        public override string ToString() =>
            $"Название:   {name} Издатель:   {publisher} Жанр: {genre} Старниц:  {pages} ";
        
    }
}
