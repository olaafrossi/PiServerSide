using Microsoft.AspNetCore.Mvc;
using PiServerSide.WebApi.Models;

namespace PiServerSide.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private static List<WeatherModel> _weatherReadings = new();

        // GET: api/<WeatherController>
        [HttpGet]
        public IEnumerable<WeatherModel> Get()
        {
            return _weatherReadings;
        }

        // POST api/<WeatherController>
        [HttpPost]
        public void Post([FromBody] WeatherModel value)
        {
            _weatherReadings.Add(value);
        }
    }
}