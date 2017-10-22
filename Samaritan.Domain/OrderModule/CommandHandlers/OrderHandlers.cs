﻿using MediatR;
using Samaritan.Domain.OrderModule.Validators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Samaritan.Domain.OrderModule.Models;
using Samaritan.Domain.OrderModule.Queries;

namespace Samaritan.Domain.OrderModule.Commands
{
    public class OrderHandlers :
    IAsyncRequestHandler<GetOrderQuery, Order>,
    IAsyncRequestHandler<BuyOrderCommand, bool>,
    IAsyncRequestHandler<SellOrderCommand, bool>
    {
        public OrderHandlers() {

        }
        
        public async Task<bool> Handle(BuyOrderCommand message)
        {
            var validator = new BuyOrderValidator();
            var result = await validator.ValidateAsync(message);

            if (result.IsValid)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> Handle(SellOrderCommand message)
        {
            var validator = new SellOrderValidator();
            var result = await validator.ValidateAsync(message);
            if (result.IsValid)
            {
                return true;
            }
            return false;
        }

        public async Task<Order> Handle(GetOrderQuery message)
        {
            var validator = new GetOrderValidator();
            var result = await validator.ValidateAsync(message);
            if (result.IsValid)
            {
                //todo
                return new Order();
            }
            //todo
            return new Order();
        }
    }
}
