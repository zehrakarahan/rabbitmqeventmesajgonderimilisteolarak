using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Messages
{
    public class PaymentDto
    {
        public string CardName { get; set; }

        public string CardNumber { get; set; }

        public string Expiration { get; set; }

        public string CW { get; set; }

        public decimal TotalPrice { get; set; }

        public CreateOrderMessageCommand CreateOrderMessageCommand { get; set; }


    }
}
