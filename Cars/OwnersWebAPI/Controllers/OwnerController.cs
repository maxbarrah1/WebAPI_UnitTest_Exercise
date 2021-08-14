using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CarsLib;

namespace OwnersWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OwnerController : ControllerBase
    {
        private static readonly Owner[] Owners = new[]
        {
            new Owner("Bill", 1234567890), new Owner("Ted", 0987654321), new Owner("Foo", 11111111111), new Owner("Bar", 2222222222)
        };

        private readonly ILogger<OwnerController> _logger;

        public OwnerController(ILogger<OwnerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Owner> Get()
        {
         return Owners;  
        }

        [HttpGet]
        [Route("/Owner/{pName}")]
        public Owner Get(string pName)
        {
            Owner c = Owners.ToList().Find(i => i.Name == pName); 
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