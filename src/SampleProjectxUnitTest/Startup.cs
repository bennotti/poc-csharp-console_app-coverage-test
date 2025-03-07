﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SampleProject.Core.BusinessRules.Interfaces;
using SampleProject.Core.InternalServices.Interfaces;
using SampleProject.Application.BusinessRules;
using SampleProject.Application.InternalServices;
using System;
using System.Collections.Generic;
using System.Text;
using SampleProject.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using SampleProjectxUnitTest.Infrastructure.Repository;

namespace SampleProjectxUnitTest
{
    public class Startup
    {
        public void ConfigureHost(IHostBuilder hostBuilder)
        {
            //hostBuilder
            //    .ConfigureAppConfiguration(builder =>
            //    {
            //        builder
            //            .AddInMemoryCollection(new Dictionary<string, string>()
            //            {
            //                {"UserName", "Alice"}
            //            })
            //            .AddJsonFile("appsettings.json")
            //            ;
            //    })
            //    ;
        }

        public void ConfigureServices(IServiceCollection services, HostBuilderContext hostBuilderContext)
        {
            services.AddDbContext<DatabaseContextMock>(options =>
            {
                options.UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString());
            });
            services.AddTransient<IGreeterService, GreeterService>();
            services.AddTransient<IGreeterBusinessRule, GreeterBusinessRule>();
        }

        public void Configure(IServiceProvider applicationServices)
        {
        }
    }
}
