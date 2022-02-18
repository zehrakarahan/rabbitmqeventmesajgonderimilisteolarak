using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Messages
{
    public class Order
    {
        public List<PaymentDto> PaymentDtos { get; set; }
    }
}
