using System;
using System.Device.Location;

namespace WeatherApplication
{
    class Location
    {

        double latitude;
        double longitude;

        public void GetLocationProperty()
        {

            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

            while (watcher.Status.ToString() != "Ready")
            {
                watcher.Start();
            }

            if (watcher.Status.ToString() == "Ready")
            {

                GeoCoordinate coord = watcher.Position.Location;

                latitude = coord.Latitude;
                longitude = coord.Longitude;

                Console.WriteLine("\n      Location loaded successfully");
                Console.WriteLine(" ");
            }

        }


        public double GetLatitude()
        {
            return latitude;
        }
        public double GetLongitude()
        {
            return longitude;
        }


    }
}
