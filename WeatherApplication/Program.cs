using System;

namespace WeatherApplication
{
    class Program
    {

        static void Main(string[] args)
        {



            Console.WriteLine("********** Press SPACE to start **********");
            ConsoleKeyInfo input = Console.ReadKey();
            Location location = new Location();

            Console.WriteLine(" ");

            if (input.Key == ConsoleKey.Spacebar)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n      Loading location. Please wait...");
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                location.GetLocationProperty();
                Console.WriteLine("    - Latitude: " + location.GetLatitude());
                Console.WriteLine("    - Longitude: " + location.GetLongitude());
                Console.ForegroundColor = ConsoleColor.Green;
                Weather weather = new Weather();
                weather.GetWeather(location.GetLatitude(), location.GetLongitude());

                Console.WriteLine(" ");
                Console.WriteLine("      Weather in " + weather.GetLocationName());

                Console.WriteLine("      Temperature: " + weather.GetTemperature());
                Console.WriteLine("      Feels like: " + weather.GetFeelsLikeTemperature());
                Console.WriteLine("      Pressure: " + weather.GetPressure());
                Console.WriteLine("      Humidity: " + weather.GetHumidity());


            }




            Console.ReadLine();

        }



    }
}
