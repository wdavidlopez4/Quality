using Microsoft.Extensions.DependencyInjection;
using Quality.Application.Facude;
using Quality.Application.ProduccionServices;
using Quality.Domain.Factories;
using Quality.Domain.Ports;
using Quality.Infrastructura.AutoMapper;
using Quality.Infrastructura.EF;
using Quality.Infrastructura.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quality.Infrastructura.IOC
{
    public class InjectionContainer
    {
        public static void Inyectar(IServiceCollection services)
        {
            //inyecciones para los servicios de application
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IFactory, Factory>();

            //inyecciones para facude de aplication
            services.AddScoped<ProductoCommandServices>();
            services.AddScoped<ProductoQueryServices>();

            //inyecciones para repository de infrastructure
            services.AddScoped<QualityContext>();

            //inyectar para los controladores de webApi
            services.AddScoped<IFacude, Facude>();

            //inyectar el autoMapeo en culaquier servicio
            services.AddScoped<IAutoMapeo, AutoMapeo>();
        }
    }
}
