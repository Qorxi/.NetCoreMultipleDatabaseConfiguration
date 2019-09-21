using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore;
using PostgreCore.Contexts;
using Microsoft.Extensions.Configuration;

namespace PostgreCore
{
    public class Startup
    {

        private readonly IConfiguration Configuration;

        public Startup(IConfiguration config)
        {
            Configuration = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFrameworkNpgsql().AddDbContextPool<PostgreCore.Contexts.PostgreSqlDatabaseContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("PostGreConnection"));
            });

            services.AddEntityFrameworkNpgsql().AddDbContextPool<PostgreCore.Contexts.MSSQLDatabaseContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("MSSQLConnection"));
            });

            services.AddSingleton<PostgreCore.DataBaseContexts.IDBContext, PostgreCore.Contexts.MSSQLDatabaseContext>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

        }
    }
}
