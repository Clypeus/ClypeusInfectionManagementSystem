using Clypeus.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Clypeus.Data.DatabaseWorkers.Repositories;
using Clypeus.Data.DatabaseWorkers.Repositories.Implementions;
using Clypeus.Data.DatabaseWorkers;
using Clypeus.Data.DatabaseWorkers.Repositories.Interfaces;

namespace Clypeus.Support.DependencyInjection
{
    public static class DataExtensions
    {
        public static void AddDataServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ClypeusContext>(options =>
                options.UseSqlServer(ConfigurationExtensions.GetConnectionString(configuration, name: "ClypeusConnectionString")));

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IDrugRespository, DrugRepository>();
            services.AddTransient<IEnquiryRepository, EnquiryRepository>();
            services.AddTransient<INotifiableDiseaseRespository, NotifiableDiseaseRepository>();
        }
    }
}
