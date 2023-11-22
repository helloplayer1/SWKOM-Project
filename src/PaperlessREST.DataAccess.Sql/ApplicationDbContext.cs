using Microsoft.EntityFrameworkCore;
using PaperlessREST.BusinessLogic.Entities;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PaperlessREST.DataAccess.Sql
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("BloggingDatabase"));
            */
        }
    }
}