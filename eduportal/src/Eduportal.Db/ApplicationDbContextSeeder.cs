using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Bogus;
using Bogus.DataSets;
using Bogus.Extensions;
using Eduportal.Models;

namespace Eduportal.Db
{
    public class ApplicationDbContextSeeder 
    {
        public static async void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = serviceProvider.GetService<ApplicationDbContext>()) 
            {
                await context.SaveChangesAsync();
            }
        }
        
        private static DateTime GenerateDateTime(int yFrom, int yTo, int mFrom, int mTo, int dFrom, int dTo) {
            var random = new Random();
            try
            {
                return new DateTime(random.Next(yFrom, yTo), random.Next(mFrom, mTo), random.Next(dFrom, dTo));
            }
            catch(Exception ex) {
                return GenerateDateTime(yFrom, yTo, mFrom, mTo, dFrom, dTo);
            }
        }

        private static string GenerateAlwaysTheSamePassword()
        {
            return "Rode_Biet_2016";
        }

        private static string GeneratePassword(int length, bool upper, bool lower, bool digits, bool signs)
        {
            var source = new List<char>();
            var random = new Random();
            var result = "";
            var i = 0;
        
            if(upper)
                source.AddRange("ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToList());
        
            if(lower)
                source.AddRange("abcdefghijklmnopqrstuvwxyz".ToList());
        
            if(digits)
                source.AddRange("1234567890".ToList());
        
            if(signs)
                source.AddRange("'&#()§!$%{}\\/.;,?:+=~[]".ToList());
        
            while(i++ < length)
                result += source[random.Next(0, source.Count)];
        
            return result;
        }
        
        public static string GeneratePassword(int length)
        {
            return GeneratePassword(length, true, true, true, true);
        }
    }
}