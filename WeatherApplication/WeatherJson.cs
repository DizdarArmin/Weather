namespace WeatherApplication
{
    class WeatherJson
    {

        public class main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
        }
        public class wind
        {
            public float speed { get; set; }
        }


        public class root
        {
            public string name { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
        }



    }
}
