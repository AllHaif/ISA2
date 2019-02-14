using System;
using CodeLibrary;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape scrape = new Scrape();
            string value = scrape.ScrapeWebPage("http://msdn.microsoft.com");
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
