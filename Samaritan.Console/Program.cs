using MediatR;
using System;
using Samaritan.Domain;
using Samaritan.Domain.OrderModule.Commands;
using Samaritan.Application.Interfaces;
using Samaritan.Application.Services;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using System.IO;
using Samaritan.Infrastructure.DependencyInjection;
using Newtonsoft.Json;
using Samaritan.Infrastructure.AutoMapper;

namespace Samaritan.Console
{
    class Program
    {
        public static IMediator Mediator { get; private set; }
        
        public static IConfigurationRoot Configuration { get; private set; }


        static void Main(string[] args)
        {
            //configure service provider
            var Configuration = new ConfigurationBuilder()
                .SetBasePath(Path.GetFullPath("."))
                .AddJsonFile("appsettings.json")
                .Build();

            IServiceCollection services = new ServiceCollection();
            InjectorBootstrapper.RegisterServices(services, Configuration);
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            //configure AutoMapper
            AutoMapperConfig.RegisterMappings();

            //get mediator
            Mediator = serviceProvider.GetService<IMediator>();;

            var buyCommand = new BuyOrderCommand();
            var sellCommand = new SellOrderCommand();

            var buyResponse = Mediator.Send(buyCommand);
            var sellResponse = Mediator.Send(sellCommand);
            ITraderInfo info = new TraderInfoAppService();
            Debug.WriteLine("Coucou");
        }


    }
}
