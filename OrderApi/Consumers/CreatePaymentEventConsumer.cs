using MassTransit;
using Shared.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApi.Consumers
{
    public class CreatePaymentEventConsumer : IConsumer<List<PaymentDto>>
    {
      
        public Task Consume(ConsumeContext<List<PaymentDto>> context)
        {
            throw new NotImplementedException();
        }
    }
}
