using CatalogApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly IServices _services;

        public ValuesController(IServices services)
        {
            _services = services;
        }
        [HttpGet]
        [Route("deneme")]
        public IActionResult DenemeRabbitMqEventMesaj()
        {
            _services.CreateOrderService();
            return Ok("rabbitmq başarılı");
        }
        [HttpGet]
        [Route("deneme2")]
        public IActionResult DenemeListRabbitMqEventMesaj()
        {
            _services.CreateListOrderService();
            return Ok("rabbitmq başarılı");
        }
    }
}
