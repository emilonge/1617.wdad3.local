using System;
using System.Collections.Generic;
using Models;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double? latitude = 51.0535;
            double? longitude = 3.7304;

            var forecast = new List<MockWeatherService>();
            for (var dayOfWeek = 0; dayOfWeek < 7; dayOfWeek++)
            {
                forecast.Add(new MockWeatherService(latitude.Value, longitude.Value, dayOfWeek));
            }

            foreach(var fc in forecast)
            {
                Console.WriteLine($@"
Day:                { MockWeatherService.DaysOfWeek[fc.DayOfWeek] }
Temp. Max:          { fc.HiTemperature } °C  
Temp. Min:          { fc.LoTemperature } °C    
Avg. Wind Speed:    { fc.AverageWindSpeed } km/h  
Condition:          { fc.Condition }     
                ");
            }
        }
    }
}
