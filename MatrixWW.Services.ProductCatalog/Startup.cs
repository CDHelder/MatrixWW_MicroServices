using MatrixWW.Services.ProductCatalog.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixWW.Services.ProductCatalog
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
            services.AddDbContext<ProductCatalogDbContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("ProductCatalogDb"));
                options.EnableSensitiveDataLogging();
                });
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MatrixWW.Services.ProductCatalog", Version = "v1" });
            });

            //Voor als je andere front-end gebruikt
            //services.AddCors(options =>
            //{
            //    options.AddPolicy("Cors", policy =>
            //    {
            //        policy.WithOrigins(Configuration.GetSection("Clients")["Mvc"])
            //           .AllowAnyHeader()
            //           .AllowAnyMethod()
            //           .AllowCredentials();
            //    });
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MatrixWW.Services.ProductCatalog v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            //app.UseCors("Cors");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
