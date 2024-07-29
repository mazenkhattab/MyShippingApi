using Microsoft.AspNetCore.Mvc;
using MyShippingApi.Factories;
using MyShippingApi.Models;

namespace MyShippingApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShippingController : ControllerBase
    {
        private readonly ShippingFactoryProvider _factoryProvider;

        public ShippingController(ShippingFactoryProvider factoryProvider)
        {
            _factoryProvider = factoryProvider;
        }

        [HttpPost("calculate")]
        public IActionResult CalculateShippingCost([FromBody] Order order, [FromQuery] ShippingMethod shippingMethod, [FromQuery] ShippingType shippingType)
        {
            try
            {
                var factory = _factoryProvider.GetFactory(shippingMethod);
                var strategy = factory.CreateStrategy(shippingType);
                double cost = strategy.CalculateShippingCost(order);
                return Ok(cost);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
