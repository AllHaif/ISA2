using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
