using Newtonsoft.Json;
using System;
using System.Net;

namespace WeatherApplication
{
    class Weather
    {
        const string APPID = "157b404184e804308a0e2d17ed154240";
        string name;
        int temperature;
        int feelsLike;
        int pressure;
        int humidity;
        public void GetWeather(double latitude, double longitude)
        {
            using (WebClient web = new WebClient())
            {
                
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?lat=" + latitude + "&lon=" + longitude + "&appid=" + APPID);
                
                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherJson.root>(json);

                WeatherJson.root output = result;

                temperature = Convert.ToInt32(output.main.temp);
                temperature = temperature - 273; // Kelvin to Celcius

                name = output.name;
                feelsLike = Convert.ToInt32(output.main.feels_like);
                feelsLike = feelsLike - 273;
                humidity = output.main.humidity;
                pressure = output.main.pressure;
            }
        }
        public int GetHumidity()
        {
            return humidity;
        }
        public int GetPressure()
        {
            return pressure;
        }


        public int GetFeelsLikeTemperature()
        {
            return feelsLike;
        }

        public string GetLocationName()
        {
            return name;
        }

        public int GetTemperature()
        {
            return temperature;
        }
    }


}
