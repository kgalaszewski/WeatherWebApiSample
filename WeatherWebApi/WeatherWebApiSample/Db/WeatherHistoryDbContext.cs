using Microsoft.EntityFrameworkCore;
using WeatherWebApiSample.Models;

namespace WeatherWebApiSample.Db
{
    public class WeatherHistoryDbContext : DbContext
    {
        public WeatherHistoryDbContext(DbContextOptions<WeatherHistoryDbContext> options) : base(options)
        {
        }

        public DbSet<FormWeatherRequest> WeatherRequests { get; set; }
    }
}
