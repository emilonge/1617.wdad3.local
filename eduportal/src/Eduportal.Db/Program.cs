using System;
using System.Threading.Tasks;

namespace Eduportal.Db
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ApplicationDbContextSeeder.Initialize();
        }
    }
}