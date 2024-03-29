﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BudgetBadgerWebApi.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
