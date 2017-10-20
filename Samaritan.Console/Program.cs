using MediatR;
using System;
using Samaritan.Domain;
using Samaritan.Domain.OrderModule.Commands;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

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

        }


    }
}
