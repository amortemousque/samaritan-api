using MediatR;
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Samaritan.Domain.OrderModule.Commands;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Samaritan.Infrastructure.DependencyInjection
{
    public class InjectorBootstrapper
    {
         public static void RegisterServices(IServiceCollection services)
        {
            services.AddLogging();
            services.AddMediatR(typeof(OrderHandlers));
        }
    }
}