using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using PaperlessREST.DataAccess.Entities;

namespace PaperlessREST.DataAccess.Sql
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<CorrespondentDao> Correspondents { get; set; }
        public DbSet<TagDao> Tags { get; set;  }
        public DbSet<DocumentDao> Documents { get; set; }

        public DbSet<DocumentTypeDao> DocumentTypes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

       
    }
}


//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//{
//    /*
//    IConfigurationRoot configuration = new ConfigurationBuilder()
//    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
//    .AddJsonFile("appsettings.json")
//    .Build();

//    optionsBuilder.UseNpgsql(Configuration.GetConnectionString("Database"));
//    */
//}