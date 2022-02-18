using MassTransit;
using Shared.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApi.Consumers
{
    public class CreateOrderEventConsumer : IConsumer<Order>
    {
        public Task Consume(ConsumeContext<Order> context)
        {
            throw new NotImplementedException();
        }
    }
}
