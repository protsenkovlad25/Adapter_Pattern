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

            CsvReading csv = new CsvReading("Files/CSV.csv");
            catalog.BookRead = csv;
            catalog.ReadingBooks();

            JsonReading json = new JsonReading("Files/JSON.json");
            JsonToCsvAdapter jsonAdapter = new JsonToCsvAdapter(json);
            catalog.BookRead = jsonAdapter;
            catalog.ReadingBooks();

            XmlReading xml = new XmlReading("Files/XML.xml");
            XmlToCsvAdapter xmlAdapter = new XmlToCsvAdapter(xml);
            catalog.BookRead = xmlAdapter;
            catalog.ReadingBooks();

            catalog.PrintBooks(catalog);
        }
    }
}
