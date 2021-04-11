using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherWebApiSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}


//class Program
//{
//    static void Main(string[] args)
//    {
//        new ApiCaller().Call().Wait();
//        Console.ReadKey();
//    }
//}

//public class ApiCaller
//{
//    public ApiCaller()
//    {

//    }

//    public async Task Call()
//    {
//        var client = new HttpClient();
//        var request = new HttpRequestMessage
//        {
//            Method = HttpMethod.Get,
//            RequestUri = new Uri("https://community-open-weather-map.p.rapidapi.com/weather?q=Gdansk%2CPoland&lat=0&lon=0&callback=test&id=2172797&lang=null&units=%22metric%22%20or%20%22imperial%22&mode=xml%2C%20html"),
//            Headers =
//                {
//                    { "x-rapidapi-key", "65c3098a75mshad91e3c47a7efffp1a16bejsn737030f59c01" },
//                    { "x-rapidapi-host", "community-open-weather-map.p.rapidapi.com" },
//                },
//        };
//        using (var response = await client.SendAsync(request))
//        {
//            response.EnsureSuccessStatusCode();
//            var body = await response.Content.ReadAsStringAsync();
//            Console.WriteLine(body);
//        }

//        // API DOC
//        // https://rapidapi.com/community/api/open-weather-map/endpoints
//    }
//}