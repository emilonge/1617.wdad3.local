using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Com.Ahs.Forcastio.Services;
using Com.Ahs.Forcastio.Models;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RunWeatherServiceGetWeatherFromLatLngAsync().Wait();
        }

        public static async Task RunWeatherServiceGetWeatherFromLatLngAsync()
        {
            ForecastIO forecast = await ForecastIOService.GetWeatherFromLatLng("51.039889", "3.725620");
            Console.WriteLine("####################################################################");
            Console.WriteLine("##                           Weather App                          ##");
            Console.WriteLine("## -------------------------------------------------------------- ##");
            Console.WriteLine("## Data from Forecast.io Service                                  ##");
            Console.WriteLine("## Developed by Philippe De Pauw - Waterschoot (drdynscript)      ##");
            Console.WriteLine("## Arteveldehogeschool                                            ##");
            Console.WriteLine("####################################################################");
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(String.Format("Weathersituation: {0}", forecast.Now.Summary));
            Console.WriteLine(String.Format("Current temperature: {0} °C, feels like {1} °C", forecast.Now.Temperature, forecast.Now.ApparentTemperature));
            Console.WriteLine(String.Format("Cloud cover: {0} %", forecast.Now.CloudCover));
            Console.WriteLine(String.Format("Humidity: {0}", forecast.Now.Humidity));
            Console.WriteLine(String.Format("Wind speed: {0} m/s", forecast.Now.WindSpeed));
            Console.WriteLine(String.Format("Wind direction: {0}", GetDirectionFromDegrees(forecast.Now.WindBearing)));
            Console.WriteLine(String.Format("Precip intensity: {0} mm/h", forecast.Now.PrecipIntensity));
            Console.WriteLine(String.Format("Precip probability: {0} %", forecast.Now.PrecipProbability));
            Console.WriteLine(String.Format("Pressure: {0} hPa", forecast.Now.Pressure));
            Console.WriteLine(String.Format("Dewpoint: {0} °C", forecast.Now.DewPoint));
            Console.WriteLine(String.Format("Ozon: {0}", forecast.Now.Ozone));
            Console.WriteLine(String.Format("Nearest storm distance: {0} km", forecast.Now.NearestStormDistance));
            Console.WriteLine(String.Format("Nearest storm direction: {0}", GetDirectionFromDegrees(forecast.Now.NearestStormBearing)));
            //Console.ResetColor();
            Console.WriteLine("####################################################################");
        }
        public static string GetDirectionFromDegrees(double degrees) {
            string direction = "N";
            if(degrees >= 0 && degrees <= 22.5) {
                direction = "N";
            }
            else if(degrees >= 22.5 && degrees <= 67.5) {
                direction = "NE";
            }
            else if(degrees >= 67.5 && degrees <= 112.5) {
                direction = "E";
            }
            else if(degrees >= 112.5 && degrees <= 157.5) {
                direction = "SE";
            }
            else if(degrees >= 157.5 && degrees <= 202.5) {
                direction = "S";
            }
            else if(degrees >= 202.5 && degrees <= 247.5) {
                direction = "SW";
            }
            else if(degrees >= 247.5 && degrees <= 292.5) {
                direction = "W";
            }
            else if(degrees >= 292.5 && degrees <= 337.5) {
                direction = "NW";
            }
            else if(degrees > 337.5) {
                direction = "N";
            }
            return direction;
        }
    }
}
