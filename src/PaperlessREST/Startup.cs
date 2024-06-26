/*
 * Paperless Rest Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using PaperlessREST.Authentication;
using PaperlessREST.Filters;
using PaperlessREST.OpenApi;
using PaperlessREST.Formatters;
using PaperlessREST.BusinessLogic.Interfaces;
using PaperlessREST.BusinessLogic;
using FluentValidation;
using PaperlessREST.BusinessLogic.Entities;
using PaperlessREST.BusinessLogic.Entities.Validators;
using PaperlessREST.DataAccess.Sql;
using Microsoft.EntityFrameworkCore;
using PaperlessREST.ServiceAgents.Interfaces;
using PaperlessREST.ServiceAgents;
using PaperlessREST.DataAccess.Interfaces;
using PaperlessREST.DataAccess.Sql.Repositories;
using System.Text;
using Minio;
using Elastic.Clients.Elasticsearch;
using EasyNetQ;

namespace PaperlessREST
{
    /// <summary>
    /// Startup
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// The application configuration.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("Database") ?? throw new InvalidOperationException("No connection string found in appsettings.json");

            string minioEndpoint = Configuration["MinIO:Endpoint"] ?? throw new InvalidOperationException("No MinIO endpoint found in appsettings.json");
            string minioAccessKey = Configuration["MinIO:AccessKey"] ?? throw new InvalidOperationException("No MinIO access key found in appsettings.json");
            string minioSecretKey = Configuration["MinIO:SecretKey"] ?? throw new InvalidOperationException("No MinIO secret key found in appsettings.json");
            string rabbitMQHost = Configuration["RabbitMQ:Host"] ?? throw new InvalidOperationException("No RabbitMQ host found in appsettings.json");
            string elasticSearchEndpoint = Configuration["ElasticSearch:Endpoint"] ?? throw new InvalidOperationException("No ElasticSearch endpoint found in appsettings.json");


            // Add framework services.
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(connectionString));
            services
                // Don't need the full MVC stack for an API, see https://andrewlock.net/comparing-startup-between-the-asp-net-core-3-templates/
                .AddControllers(options =>
                {
                    options.InputFormatters.Insert(0, new InputFormatterStream());
                })
                .AddNewtonsoftJson(opts =>
                {
                    opts.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                    opts.SerializerSettings.Converters.Add(new StringEnumConverter
                    {
                        NamingStrategy = new CamelCaseNamingStrategy()
                    });
                });
            services.AddMinio(configureClient =>
            {
                configureClient.WithEndpoint(minioEndpoint);
                configureClient.WithSSL(false);
                configureClient.WithCredentials(minioAccessKey, minioSecretKey);
            });
            services
                .AddSwaggerGen(c =>
                {
                    c.EnableAnnotations(enableAnnotationsForInheritance: true, enableAnnotationsForPolymorphism: true);

                    c.SwaggerDoc("1.0", new OpenApiInfo
                    {
                        Title = "Paperless Rest Server",
                        Description = "Paperless Rest Server (ASP.NET Core 6.0)",
                        TermsOfService = new Uri("https://github.com/openapitools/openapi-generator"),
                        Contact = new OpenApiContact
                        {
                            Name = "OpenAPI-Generator Contributors",
                            Url = new Uri("https://github.com/openapitools/openapi-generator"),
                            Email = ""
                        },
                        License = new OpenApiLicense
                        {
                            Name = "NoLicense",
                            Url = new Uri("http://localhost")
                        },
                        Version = "1.0",
                    });
                    c.CustomSchemaIds(type => type.FriendlyId(true));
                    c.IncludeXmlComments($"{AppContext.BaseDirectory}{Path.DirectorySeparatorChar}{Assembly.GetEntryAssembly().GetName().Name}.xml");

                    // Include DataAnnotation attributes on Controller Action parameters as OpenAPI validation rules (e.g required, pattern, ..)
                    // Use [ValidateModelState] on Actions to actually validate it in C# as well!
                    c.OperationFilter<GeneratePathParamsValidationFilter>();
                });
            services.AddScoped<ElasticsearchClient>(_ => new ElasticsearchClient(new Uri(elasticSearchEndpoint)));
            services.AddScoped<IBus>(_ => RabbitHutch.CreateBus($"host={rabbitMQHost}"));
            services.AddSwaggerGenNewtonsoftSupport();
            services.AddAutoMapper(typeof(RestProfile));
            services.AddScoped<IDocumentLogic, DocumentLogic>();
            services.AddScoped<IDocumentTypeLogic, DocumentTypeLogic>();
            services.AddScoped<ITagLogic, TagLogic>();
            services.AddScoped<ICorrespondentLogic, CorrespondentLogic>();
            services.AddScoped<IValidator<Document>, DocumentValidator>();
            services.AddScoped<IValidator<DocumentType>, DocumentTypeValidator>();
            services.AddScoped<IValidator<Correspondent>, CorrespondentValidator>();
            services.AddScoped<IValidator<Tag>, TagValidator>();
            services.AddScoped<IValidator<UserInfo>, UserInfoValidator>();
            services.AddScoped<IDocumentRepository, DocumentRepository>();
            services.AddLogging();
            //services.AddScoped MinIo

        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationDbContext context)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
            else
            {
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseSwagger(c =>
                {
                    c.RouteTemplate = "openapi/{documentName}/openapi.json";
                })
                .UseSwaggerUI(c =>
                {
                    // set route prefix to openapi, e.g. http://localhost:8080/openapi/index.html
                    c.RoutePrefix = "openapi";
                    //TODO: Either use the SwaggerGen generated OpenAPI contract (generated from C# classes)
                    c.SwaggerEndpoint("/openapi/1.0/openapi.json", "Paperless Rest Server");

                    //TODO: Or alternatively use the original OpenAPI contract that's included in the static files
                    // c.SwaggerEndpoint("/openapi-original.json", "Paperless Rest Server Original");
                });
            app.UseRouting();
            app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
        }
    }
}
