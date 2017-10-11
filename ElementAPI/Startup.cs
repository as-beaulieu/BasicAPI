using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ElementAPI.Entities;

namespace ElementAPI
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
            services.AddMvc();

            //Variable to hold 'connectionString' for DB
            var connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=elementAPI";
            //? host=localhost port=5432 dbname=mydb connect_timeout=10

            //For localDB with Microsoft SQL Server
            //var connectionString = @"Server=(localdb)\mssqllocaldb;Database=CityInfoDB;Trusted_Connection=True;";

            //If using Microsoft SQL Server
            //services.AddDbContext<CityInfoContext>(o => o.UseSqlServer(connectionString));

            //I want to use PostgreSQL
        }

        private void RegisterDbContext()
        {
            var connectionString = "Server=localhost;Port=5432;User Id=postgres;password=postgres;Database=elementAPI";
            //var documentsOptionBuilder = new DbContextOptionsBuilder<>
        }

        //public DbContextOptions<>

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env,
            ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            loggerFactory.AddDebug(); //Can customize level of logging with 'LogLevel'

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler();
            }

            app.UseStatusCodePages();

            app.UseMvc();
        }
    }
}
