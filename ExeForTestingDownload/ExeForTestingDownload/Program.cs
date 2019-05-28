using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ExeForTestingDownload
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("ftp://videodarom:1169@videodarom.no-ip.org/Alpha.2018.BDRip.VideoDarom.ru.mkv", "Film");
            }
        }
    }
}
