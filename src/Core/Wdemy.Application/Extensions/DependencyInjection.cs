using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Interfaces.Services;
using Wdemy.Application.Services;

namespace Wdemy.Application.Extensions
{
        public static class DependencyInjection
        {
            public static IServiceCollection AddBusinessServices(this IServiceCollection services)
            {
                services.AddAutoMapper(Assembly.GetExecutingAssembly());

                services.AddScoped<ICourseService, CourseService>();
                services.AddScoped<ITrainerService, TrainerService>();
                services.AddScoped<IVideoService, VideoService>();

            return services;
            }
        }
    
}
