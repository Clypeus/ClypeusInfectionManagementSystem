using Clypeus.Data.Model;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clypeus.Support.DependencyInjection
{
    public static class DataExtensions
    {
        public static void AddDataServices(this IServiceCollection services)
        {
            services.AddTransient<ClypeusContext>();
        }
    }
}
