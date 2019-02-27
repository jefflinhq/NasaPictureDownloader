using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Newtonsoft.Json;

namespace NasaApi
{
    public class NasaApod
    {
        const string nasaApodUrl= "https://api.nasa.gov/planetary/apod?api_key=oHneS2DMNT9l0ZyMwn6xNgngXMHBpX94dGrnU58Q&date=";

        public NasaApodData GetNasaApod(DateTime date)
        {
            using (WebClient client = new WebClient())
            {
                var searchUrl = nasaApodUrl + date.ToString("yyyy-MM-dd");
                var jsonString = client.DownloadString(searchUrl);

                return JsonConvert.DeserializeObject<NasaApodData>(jsonString);
            }
        }


    }
}
