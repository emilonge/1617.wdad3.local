using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Services;
using Models;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RunRandomUserMeServiceGetRandomUsersByAmount().Wait();
        }

        public static async Task RunRandomUserMeServiceGetRandomUsersByAmount()
        {
            try
            {
                RandomUserMeSearch s = await RandomUserMeService.GetRandomUsersByAmount(50);

                foreach (var user in s.Users)
                {
                    Console.WriteLine("========================================================================================");
                    Console.WriteLine(user.ToConsoleString());
                    Console.WriteLine("========================================================================================");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("========================================================================================");
                Console.WriteLine("Error: {0}", ex.Message);
                Console.WriteLine("========================================================================================");
            }
            
        }
    }
}
