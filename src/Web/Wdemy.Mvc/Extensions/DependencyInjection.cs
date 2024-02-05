using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Reflection;
using Wdemy.Application.Interfaces.Repository;
using Wdemy.Mvc.Authorization;
using Wdemy.Persistence.Interfaces.Services;
using Wdemy.Persistence.Repositories;

namespace Wdemy.Mvc.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMvcServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }

}
