using Clypeus.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Clypeus.Support.DependencyInjection
{
    public static class DataExtensions
    {
        public static void AddDataServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ClypeusContext>(options =>
                options.UseSqlServer(ConfigurationExtensions.GetConnectionString(configuration, name: "ClypeusConnectionString")));
        }
    }
}
