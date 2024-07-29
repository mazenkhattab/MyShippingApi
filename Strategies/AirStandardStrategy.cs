using MyShippingApi.Models;

namespace MyShippingApi.Strategies
{
    public class AirStandardStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(Order order)
        {
            return 10.0;
        }
    }
}
