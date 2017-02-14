using System;

namespace Models
{
    public class MockWeatherService
    {
        public int HiTemperature { get; }
        public int LoTemperature { get; }
        public int AverageWindSpeed { get; }
        public string Condition { get; }
        public int DayOfWeek  { get; }
        
        private static readonly string[] Conditions = new string[]
        {
            "Sunny",
            "Mostly Sunny",
            "Partly Sunny",
            "Partly Cloudy",
            "Mostly Cloudy",
            "Rain"
        };

        public static readonly string[] DaysOfWeek = new string[]
        {
            "Sun",
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat"
        };

        public MockWeatherService(double latitude, double longitude, int dayOfWeek) : base() 
        {
            var generator = new Random((int)(latitude + longitude) + dayOfWeek);
            DayOfWeek = dayOfWeek;

            HiTemperature = generator.Next(0, 56);
            LoTemperature = generator.Next(0, HiTemperature);
            AverageWindSpeed = generator.Next(0,180);
            Condition = Conditions[generator.Next(0, Conditions.Length - 1)];
        }

        public override string ToString() => "Mock Weather Service";
    }
}