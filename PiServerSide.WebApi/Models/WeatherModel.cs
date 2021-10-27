namespace PiServerSide.WebApi.Models
{
    public class WeatherModel
    {
        public double Pressure { get; set; }
        public double Humidity { get; set; }
        public double Altitude { get; set; }
        public double Temperature { get; set; }
        public string Units { get; set; }
    }
}
