using BookShop_Adapter.Adapters;
using BookShop_Adapter.BookShop;
using BookShop_Adapter.Functionality;
using System;

namespace BookShop_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            CsvReading csv = new CsvReading(@"C:\Users\79825\source\repos\BookShop_Adapter\Files\CSV.csv");
            catalog.BookRead = csv;
            catalog.ReadingBooks();

            JsonReading json = new JsonReading(@"C:\Users\79825\source\repos\BookShop_Adapter\Files\JSON.json");
            JsonToCsvAdapter jsonAdapter = new JsonToCsvAdapter(json);
            catalog.BookRead = jsonAdapter;
            catalog.ReadingBooks();

            XmlReading xml = new XmlReading(@"C:\Users\79825\source\repos\BookShop_Adapter\Files\XML.xml");
            XmlToCsvAdapter xmlAdapter = new XmlToCsvAdapter(xml);
            catalog.BookRead = xmlAdapter;
            catalog.ReadingBooks();

            catalog.PrintBooks(catalog);
        }
    }
}
