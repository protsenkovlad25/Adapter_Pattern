using BookShop_Adapter.BookShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BookShop_Adapter.Functionality
{
    class XmlReading : IReading
    {
        public string FileLocation { get; set; }

        public XmlReading(string fileLocation)
        {
            FileLocation = fileLocation;
        }

        public List<Book> Reading()
        {
            List<Book> books = new List<Book>();

            XmlDocument document = new XmlDocument();
            document.Load(FileLocation);

            try
            {
                XmlElement elements = document.DocumentElement;
                foreach(XmlElement element in elements.ChildNodes)
                {
                    Book book = new Book(
                        element.ChildNodes[0].InnerText,
                        element.ChildNodes[1].InnerText,
                        element.ChildNodes[2].InnerText,
                        int.Parse(element.ChildNodes[3].InnerText),
                        int.Parse(element.ChildNodes[4].InnerText));

                    books.Add(book);
                }
            }
            catch
            {
                Console.WriteLine("Fail");
            }

            return books;
        }
    }
}
