using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Eduportal.Models;

namespace Eduportal.Db
{
    public class ApplicationDbContextFactory : IDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseNpgsql("User ID=postgres;Password=wickedman;Host=localhost;Port=5432;Database=eduportal;Pooling=true;");
            return new ApplicationDbContext(builder.Options);
        }
    }
}