using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

/*
namespace TodoApi.Models
{
    public class TodoContextFactory : IDbContextFactory<TodoContext>
    {
        public TodoContext Create()
        {
            var environmentName = Environment.GetEnvironmentVariable("Hosting:Environment");
            var basePath = AppContext.BaseDirectory;
            return Create(basePath, environmentName);
        }

        public TodoContext Create(DbContextFactoryOptions options)
        {
            return Create(options.ContentRootPath, options.EnvironmentName);
        }

        private TodoContext Create(string basePath, string environmentName)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json")
            .AddJsonFile($"appsettings.{environmentName}.json", true)
            .AddEnvironmentVariables();

            var config = builder.Build();
            var connstr = config.GetConnectionString("DefaultConnection");

            if (string.IsNullOrWhiteSpace(connstr) == true)
            {
                throw new InvalidOperationException(
                "Could not find a connection string named '(DefaultConnection)'.");
            }
            else
            {
                return Create(connstr);
            }
        }

        private TodoContext Create(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentException(
                $"{nameof(connectionString)} is null or empty.",
                nameof(connectionString));

            var optionsBuilder = new DbContextOptionsBuilder<TodoContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new TodoContext(optionsBuilder.Options);
        }
    }
}
*/
