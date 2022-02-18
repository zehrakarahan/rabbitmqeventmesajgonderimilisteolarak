using MassTransit;
using Shared.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogApi.Services
{
    public class ConcreteServices : IServices
    {
        public readonly IPublishEndpoint _publishEndpoint;

        public ConcreteServices(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        public void CreateListOrderService()
        {
            Order order = new Order();
            order.PaymentDtos = new List<PaymentDto>();
            List<PaymentDto> paymentDtos = new List<PaymentDto>();
            paymentDtos.Add(new PaymentDto
            {
                CardName = "zehra",
                CardNumber = "deneme proje",
                CW = "deneme deneme",
                Expiration = "expiration",
                TotalPrice = 234,
                CreateOrderMessageCommand = new CreateOrderMessageCommand
                {
                    BuyerId = "buyerid",
                    Province = "province",
                    Line = "line",
                    District = "district",
                    ZipCode = "zipcode",
                    OrderItems = new List<OrderItem>()
                    {
                        new OrderItem
                        {
                            PictureUrl="pictureUrl",
                            Price=Convert.ToDecimal("23"),
                            ProductId="productid",
                            ProductName="productname"
                        }
                    }
                }

            });
            paymentDtos.Add(new PaymentDto
            {
                CardName = "zehra2",
                CardNumber = "deneme proje2",
                CW = "deneme deneme2",
                Expiration = "expiration2",
                TotalPrice = 2342,
                CreateOrderMessageCommand = new CreateOrderMessageCommand
                {
                    BuyerId = "buyerid2",
                    Province = "province2",
                    Line = "line2",
                    District = "district2",
                    ZipCode = "zipcode2",
                    OrderItems = new List<OrderItem>()
                    {
                        new OrderItem
                        {
                            PictureUrl="pictureUrl2",
                            Price=Convert.ToDecimal("232"),
                            ProductId="productid2",
                            ProductName="productname2"
                        }
                    }
                }

            });
            order.PaymentDtos = paymentDtos;
            _publishEndpoint.Publish<Order>(order);
        }

        public void CreateOrderService()
        {
            List<PaymentDto> paymentDtos = new List<PaymentDto>();
            paymentDtos.Add(new PaymentDto
            {
                CardName = "zehra",
                CardNumber = "deneme proje",
                CW = "deneme deneme",
                Expiration = "expiration",
                TotalPrice = 234,
                CreateOrderMessageCommand = new CreateOrderMessageCommand
                {
                    BuyerId = "buyerid",
                    Province = "province",
                    Line = "line",
                    District = "district",
                    ZipCode = "zipcode",
                    OrderItems = new List<OrderItem>()
                    {
                        new OrderItem
                        {
                            PictureUrl="pictureUrl",
                            Price=Convert.ToDecimal("23"),
                            ProductId="productid",
                            ProductName="productname"
                        }
                    }
                }

            });
            paymentDtos.Add(new PaymentDto
            {
                CardName = "zehra2",
                CardNumber = "deneme proje2",
                CW = "deneme deneme2",
                Expiration = "expiration2",
                TotalPrice = 2342,
                CreateOrderMessageCommand = new CreateOrderMessageCommand
                {
                    BuyerId = "buyerid2",
                    Province = "province2",
                    Line = "line2",
                    District = "district2",
                    ZipCode = "zipcode2",
                    OrderItems = new List<OrderItem>()
                    {
                        new OrderItem
                        {
                            PictureUrl="pictureUrl2",
                            Price=Convert.ToDecimal("232"),
                            ProductId="productid2",
                            ProductName="productname2"
                        }
                    }
                }

            });
            _publishEndpoint.Publish<List<PaymentDto>>(paymentDtos);
        }
    }
}
