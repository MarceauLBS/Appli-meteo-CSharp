using System;
using System.Net.Http;

namespace Application_meteo_csharp
{
    public class Config
    {
        public readonly string _apiKey;

        public Config()
        {
            _apiKey = "61d8e8b5c2fb9b8f78a43cf6904093ad";
        }

        public Config(string apikey)
        {
            _apiKey = apikey;
        }
    }
}
