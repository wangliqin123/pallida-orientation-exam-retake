using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using FashionWebStoreApp.Entities;
using Microsoft.EntityFrameworkCore;
using FashionWebStoreApp.Repositories;
using FashionWebStoreApp.Services;

namespace FashionWebStoreApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<FashionStoreContext>();
            services.AddScoped<FashionStoreRepository>();
            services.AddScoped<FashionStoreService>();
            services.AddDbContext<FashionStoreContext>(options => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=warehousemaster;Integrated Security=True;Connect Timeout=30"));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
        }
    }
}