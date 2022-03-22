using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Microsoft.OpenApi.Models;
using ECommerce_Light_API.DependencyInjection;
using ECommerce_Light_Infrastructure.DBSettings;
using ECommerce_Light_Infrastructure.Abstraction;
using ECommerce_Light_Infrastructure.DBConfiguration;
using ECommerce_Light_Infrastructure.Repositories;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Infrastructure.Mappers;

namespace ECommerce_Light_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.MapAllPOCOs();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "ECommerce Light API",
                    Version = "v1",
                    Description = "Implementation of a light Ecommerce web api",
                    Contact = new OpenApiContact
                    {
                        Name = "Khalil Warid",
                        Email = "khalil.warid@gmail.com",
                        Url = new Uri("https://github.com/WARIDKhalil/ECommerce_Light"),
                    },
                });
            });

            services.Configure<DBSettings>(options =>
            {
                options.ConnectionString = Configuration.GetSection("DatabaseSettings:CONNECTION_STRING").Value;
                options.DatabaseName = Configuration.GetSection("DatabaseSettings:DATABASENAME").Value;
            });

            services.AddSingleton<IDBContext,MongoDBContext>();

            services.AddSingleton<IRepository<Role,string>,RoleRepository>();

            services.AddMediator(ServiceLifetime.Singleton, typeof(Startup));

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ECommerce Light API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
