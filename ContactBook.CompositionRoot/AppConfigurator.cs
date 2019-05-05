using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using ContactBook.DAL;
using System.IO;
using AutoMapper;

namespace ContactBook.CompositionRoot
{
    public static class AppConfigurator
    {
        public static void ConfigureApplication(IServiceCollection services)
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();

            string connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
