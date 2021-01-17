using Clypeus.Services.Interfaces.Medicinals;
using Clypeus.Services.Interfaces.Principles;
using Clypeus.Services.Medicinals;
using Clypeus.Services.Principles;
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
            services.AddTransient<INotifiableDiseaseService, NotifiableDiseaseService>();
            services.AddTransient<IEnquiryService, EnquiryService>();
        }
    }
}
