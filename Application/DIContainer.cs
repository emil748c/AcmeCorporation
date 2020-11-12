using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Application
{
    public static class DIContainer
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddScoped<ISubmissionService, SubmissionService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;

        }
    }
}
