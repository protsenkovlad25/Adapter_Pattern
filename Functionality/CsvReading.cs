using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShop_Adapter.BookShop;

namespace BookShop_Adapter.Functionality
{
    class CsvReading : IReading
    {
        public string FileLocation { get; set; }

        public CsvReading(string fileLocation)
        {
            FileLocation = fileLocation;
        }

        public List<Book> Reading()
        {
            List<Book> books = new List<Book>();
            string[] contentbook = File.ReadAllLines(FileLocation);

            foreach (string content in contentbook)
            {
                string[] attributes = content.Split(',');

                Book readingBook = new Book(
                    attributes[0],
                    attributes[1],
                    attributes[2],
                    int.Parse(attributes[3]),
                    int.Parse(attributes[4]));

                books.Add(readingBook);
            }

            return books;
        }
    }
}
