using MediatR;
using System;
using Samaritan.Domain;
using Samaritan.Domain.OrderModule.Commands;
using Samaritan.Application.Interfaces;
using Samaritan.Application.Services;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Samaritan.Console
{
    class Program
    {
        public static IMediator _mediator { get; private set; }

        static void Main(string[] args)
        {

            //setup our DI
            IServiceCollection serviceProvider = new ServiceCollection();
            serviceProvider.AddMediatR(typeof(OrderHandlers));
            var providerInstance = serviceProvider.BuildServiceProvider();



            //do the actual work here
            var mediator = providerInstance.GetService<IMediator>();
            _mediator = mediator;

            var buyCommand = new BuyOrderCommand();
            var sellCommand = new SellOrderCommand();

            var buyResponse = _mediator.Send(buyCommand);
            var sellResponse = _mediator.Send(sellCommand);
            ITraderInfo info = new TraderInfoAppService();
            Debug.WriteLine("Coucou");
        }


    }
}
