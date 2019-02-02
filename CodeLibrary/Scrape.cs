using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CodeLibrary
{
    public class Scrape
    {
        public string ScrapeWebPage(string url)
        {
            return GetWebpage(url);
        }

        public string ScrapeWebPage(string url, string filepath)
        {
            string reply = GetWebpage(url);

            File.WriteAllText(filepath, url);
            return reply;
        }

        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            string content = client.DownloadString(url);
            content += "\nThat's it!";
            return content;
        }
    }
}
