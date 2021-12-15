using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Adapter.BookShop
{
    class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }

        public Book(string author, string title, string genre, int year, int pages)
        {
            Author = author;
            Title = title;
            Genre = genre;
            Year = year;
            Pages = pages;
        }
    }
}
