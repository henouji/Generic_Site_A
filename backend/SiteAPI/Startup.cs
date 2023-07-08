using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using SiteAPI.Models;
using MongoDB.Driver;
using SiteAPI.Repositories.Contracts;
using SiteAPI.Repositories;
using SiteAPI.Services;
using SiteAPI.Services.Contracts;

namespace SiteAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();            

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Site API", Version = "v1" });
            });

            // Add mongo db client and specify the database 
            services.AddSingleton(x =>
            {
                string connString = Configuration.GetConnectionString("APIDatabase");
                string dbName = Configuration.GetValue<string>("APIDatabase:DatabaseName");
                var client = new MongoClient(connString);
                var db = client.GetDatabase(dbName);
                return db;
            });

            // Register Repositories
            services.AddScoped<IUserRepository, UserRepository>();

            // Register Services
            services.AddScoped<IUserService, UserService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Site API v1");
                c.RoutePrefix = "swagger";
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}