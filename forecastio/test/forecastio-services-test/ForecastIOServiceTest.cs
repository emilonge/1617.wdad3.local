using System;
using Xunit;
using System.Collections.Generic;
using System.Threading.Tasks;
using Com.Ahs.Forcastio.Services;
using Com.Ahs.Forcastio.Models;

namespace Tests
{
    public class ForecastIOServiceTest
    {
        [Fact]
        public async Task GetWeatherFromLocation() 
        {
            ForecastIO forecast = await ForecastIOService.GetWeatherFromLatLng("51.039889", "3.725620");

            Assert.NotNull(forecast);
        }
    }
}
