using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackApp.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<FeedbackDBContext>
    {
        public FeedbackDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<FeedbackDBContext>();

            var connectionString = configuration.GetConnectionString("LocalPC");

            builder.UseSqlServer(connectionString);

            return new FeedbackDBContext(builder.Options);
        }
    }
}
