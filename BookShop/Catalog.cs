using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShop_Adapter.Functionality;

namespace BookShop_Adapter.BookShop
{
    class Catalog
    {
        public List<Book> Books = new List<Book>();
        public IReading BookRead { get; set; }

        public Catalog()
        {
            BookRead = null;
        }

        public void ReadingBooks()
        {
            if (BookRead != null)
                Books.AddRange(BookRead.Reading());
            else
                Console.WriteLine("Fail");
        }

        public void PrintBooks(Catalog catalog)
        {
            foreach (Book book in catalog.Books)
            {
                Console.WriteLine($"{book.Author}\n" +
                    $"{book.Title}\n" +
                    $"{book.Genre}\n" +
                    $"{book.Year}\n" +
                    $"{book.Pages}\n");
            }
        }
    }
}
