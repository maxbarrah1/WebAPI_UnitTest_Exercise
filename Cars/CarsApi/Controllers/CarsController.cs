using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CarsLib;

namespace CarsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {

        List<Car> cars = new List<Car>(){
                                        new Car("ABC123", 0), 
                                        new Car("CBA321", 150), 
                                        new Car("ZXC789", 10), 
                                        new Car("CXZ987", 100)
                                        };



        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return cars.ToArray();
        }

        [HttpGet]
        [Route("/Cars/{pRego}")]
        public Car Get(string pRego)
        {
            Car c = cars.Find(i => i.Rego == pRego); 
            return c;
        }
    }
}




            /*
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
            */
