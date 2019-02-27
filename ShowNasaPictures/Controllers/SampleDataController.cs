using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using NasaApi;

namespace ShowNasaPictures.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<NasaApodData> WeatherForecasts()
        {
            var nasaapi = new NasaApi.NasaApod();
            var result = new List<NasaApodData>();

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
                            result.Add(data);
                        }
                    }
                }
            }

            return result;
        }

    }
}
