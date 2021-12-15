using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShop_Adapter.BookShop;
using Newtonsoft.Json;

namespace BookShop_Adapter.Functionality
{
    class JsonReading : IReading
    {
        public string FileLocation { get; set; }

        public JsonReading(string fileLocation)
        {
            FileLocation = fileLocation;
        }

        public List<Book> Reading()
        {
            string json = File.ReadAllText(FileLocation);
           List<Book> books = JsonConvert.DeserializeObject<List<Book>>(json);

            if(books == null)
                Console.WriteLine("Fail");

            return books;
        }
    }
}
