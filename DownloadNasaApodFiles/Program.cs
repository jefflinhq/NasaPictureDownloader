using System;
using System.Net;
using System.IO;
using NasaApi;

namespace DownloadNasaApodFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start downloading...");

            DownloadFiles();
            Console.WriteLine("Download completed.");

        }

        static void DownloadFiles()
        {
            var nasaapi = new NasaApi.NasaApod();
            NasaApodData data;

            FileStream fileStream = new FileStream("dates.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                while (reader.Peek() >= 0)
                {
                    string line = reader.ReadLine();

                    DateTime? date = DateParser.ParseDate(line);
                    if (date != null)
                    {
                        data = nasaapi.GetNasaApod((DateTime)date);

                        if (!string.IsNullOrEmpty(data.url))
                        {
                            using (WebClient client = new WebClient())
                            {
                                client.DownloadFile(data.url, data.date.ToShortDateString() + ".jpg");
                            }
                        }
                    }
                }
            }
        }
       
    }
}
