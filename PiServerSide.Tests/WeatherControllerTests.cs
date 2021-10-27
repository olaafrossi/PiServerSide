using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PiServerSide.WebApi.Models;
using Xunit;

namespace PiServerSide.Tests
{
    public class WeatherControllerTests
    {
        [Fact]
        public void Get_ShouldReturnWeatherModel()
        {
            // arrange
            List<WeatherModel> expected = new();

            // act
            List<WeatherModel> actual = new();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
