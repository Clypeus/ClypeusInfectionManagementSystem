using Clypeus.Services.Interfaces.Medicinals;
using Clypeus.Services.Medicinals;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clypeus.Support.DependencyInjection
{
    public static class ImplementionExtensions
    {
        public static void AddImplementionServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDrugService, DrugService>();
        }
    }
}
