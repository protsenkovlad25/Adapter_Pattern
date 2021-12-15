using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShop_Adapter.BookShop;
using BookShop_Adapter.Functionality;

namespace BookShop_Adapter.Adapters
{
    class XmlToCsvAdapter : IReading
    {
        private IReading BookRead { get; set; }

        public XmlToCsvAdapter(IReading reading)
        {
            BookRead = reading;
        }

        public List<Book> Reading()
        {
            return BookRead.Reading();
        }
    }
}
