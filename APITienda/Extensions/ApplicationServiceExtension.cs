

using Core.Interfaces;
using Infraestructure.Repository;
using Infraestructure.UnitOfWork;
using Microsoft.AspNetCore.StaticFiles;

namespace APITienda.Extensions;

    public static class ApplicationServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()//WithOrigins("https://domini.com")
                .AllowAnyMethod() //WithMethods("GET", "POST")
                .AllowAnyHeader()); //WithHeader(*accept*, "content-type")
            });

        public static void AddAplicacionServices(this IServiceCollection services)
        {
            //services.AddScoped<IPais, PaisRepository>();
            //services.AddScoped<IRegion, RegionRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
