using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShop_Adapter.BookShop;

namespace BookShop_Adapter.Functionality
{
    interface IReading
    {
        List<Book> Reading();
    }
}
