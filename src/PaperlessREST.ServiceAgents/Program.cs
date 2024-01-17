
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Minio;
using PaperlessREST.DataAccess.Interfaces;
using PaperlessREST.DataAccess.Sql;
using PaperlessREST.DataAccess.Sql.Repositories;
using PaperlessREST.ServiceAgents;
using PaperlessREST.ServiceAgents.Interfaces;

IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

string connectionString = configuration.GetConnectionString("Database") ?? throw new InvalidOperationException("No connection string found in appsettings.json");
string minioEndpoint = configuration["MinIO:Endpoint"] ?? throw new InvalidOperationException("No MinIO endpoint found in appsettings.json");
string minioAccessKey = configuration["MinIO:AccessKey"] ?? throw new InvalidOperationException("No MinIO access key found in appsettings.json");
string minioSecretKey = configuration["MinIO:SecretKey"] ?? throw new InvalidOperationException("No MinIO secret key found in appsettings.json");

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        // Add framework services.
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(connectionString));
        services.AddScoped<IDocumentRepository, DocumentRepository>();
        services.AddScoped<OCROptions>(_ => new OCROptions());
        services.AddScoped<IOCRService, GhostScriptOCRService>();
        services.AddMinio(configureClient =>
        {
            configureClient.WithEndpoint(minioEndpoint);
            configureClient.WithSSL(false);
            configureClient.WithCredentials(minioAccessKey, minioSecretKey);
        });
    })
    .Build();

await host.RunAsync();
