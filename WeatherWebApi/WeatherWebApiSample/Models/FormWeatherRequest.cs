namespace WeatherWebApiSample.Models
{
    public class FormWeatherRequest
    {
        public int Id { get; set; }
        public int TemperatureC { get; set; }

        public string Country { get; set; }
        public string City { get; set; }
        public string LocationDetails { get; set; }
    }
}
