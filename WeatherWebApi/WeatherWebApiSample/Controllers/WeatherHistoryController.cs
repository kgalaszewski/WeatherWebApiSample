using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WeatherWebApiSample.Db;
using WeatherWebApiSample.Models;

namespace WeatherWebApiSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherHistoryController : ControllerBase
    {
        private readonly WeatherHistoryDbContext _dbContext;

        public WeatherHistoryController(WeatherHistoryDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }

        [HttpGet]
        [ResponseCache(Duration = 120, Location = ResponseCacheLocation.Client)]
        public FormWeatherRequest Get(int Id)
        {
            return _dbContext.WeatherRequests.Find(Id);
        }

        [HttpGet]
        [Route("History")]
        [ResponseCache(Duration = 2, Location = ResponseCacheLocation.Client)]
        public IEnumerable<FormWeatherRequest> Get()
        {
            return _dbContext.WeatherRequests.ToList();
        }

        [HttpPost]
        public int Post(FormWeatherRequest weatherInput)
        {
            if (!ModelState.IsValid)
                return 0;

            var weatherDescription = _dbContext.WeatherRequests.Add(new FormWeatherRequest
            {
                City = weatherInput.City,
                Country = weatherInput.Country,
                LocationDetails = weatherInput.LocationDetails
            });

            _dbContext.SaveChanges();

            return weatherDescription.Entity.Id;
        }
    }
}
