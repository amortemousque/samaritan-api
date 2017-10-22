using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Nest;
using MediatR;
using Samaritan.Infrastructure.ElasticSearch;
using Samaritan.Domain;
using Samaritan.Domain.OrderModule.Commands;
using Samaritan.Application.Interfaces;
using Samaritan.Application.Services;
using Samaritan.Infrastructure.DependencyInjection;
using Samaritan.Infrastructure.AutoMapper;

namespace Samaritan.Console
{
    class Program
    {
        public static ServiceProvider ServiceProvider { get; private set; }
        public static IMediator Mediator { get; private set; }

        static void Main(string[] args)
        {
            Setup();

            Mediator = ServiceProvider.GetService<IMediator>();

            var buyCommand = new BuyOrderCommand();
            var sellCommand = new SellOrderCommand();

            var buyResponse = Mediator.Send(buyCommand);
            var sellResponse = Mediator.Send(sellCommand);
            ITraderInfo info = new TraderInfoAppService();
            Debug.WriteLine("Coucou");
        }

        static private void Setup() {

            IServiceCollection services = new ServiceCollection();

            //configure appSettings
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            services.AddSingleton<IConfigurationRoot>(configuration);

            //configure elasticSearch
            var settings = new ConnectionSettings(new Uri(configuration["ElasticSearch:Uri"]));
            settings.BasicAuthentication(configuration["ElasticSearch:Login"],configuration["ElasticSearch:Password"]);
            var elasticClient = new ElasticClient(settings);

            ElasticSearchConfig.RegisterMappings(elasticClient);

            services.AddSingleton<ElasticClient>(elasticClient);

            //configure service Ioc
            InjectorBootstrapper.RegisterServices(services);

            //configure AutoMapper
            AutoMapperConfig.RegisterMappings();

            ServiceProvider = services.BuildServiceProvider();
        }   
    }
}
