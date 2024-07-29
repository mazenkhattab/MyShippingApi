using MyShippingApi.Models;
namespace MyShippingApi.Strategies

{
    public class AirExpressStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(Order order)
        {
            return 20.0;
        }
    }
}
