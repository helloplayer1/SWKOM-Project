using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PaperlessREST.DataAccess.Sql;

namespace PaperlessREST
{
    /// <summary>
    /// Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var app = CreateHostBuilder(args).Build();
            using var scope = app.Services.CreateScope();
            using var context = scope.ServiceProvider.GetService<ApplicationDbContext>();
            context.Database.EnsureCreated();
            app.Run();
        }

        /// <summary>
        /// Create the host builder.
        /// </summary>
        /// <param name="args"></param>
        /// <returns>IHostBuilder</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                   webBuilder.UseStartup<Startup>()
                             .UseUrls("http://0.0.0.0:8080/");
                });
    }
}
