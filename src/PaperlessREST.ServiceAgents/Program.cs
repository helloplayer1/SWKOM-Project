
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PaperlessREST.DataAccess.Interfaces;
using PaperlessREST.DataAccess.Sql;
using PaperlessREST.DataAccess.Sql.Repositories;
using PaperlessREST.ServiceAgents;

IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

string? connectionString = configuration.GetConnectionString("Database");
if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("No connection string found in appsettings.json");
}

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        // Add framework services.
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(connectionString));
        services.AddScoped<IDocumentRepository, DocumentRepository>();
    })
    .Build();

await host.RunAsync();
