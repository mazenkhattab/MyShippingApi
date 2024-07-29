using MyShippingApi.Models;

namespace MyShippingApi.Strategies
{
    public interface IShippingStrategy
    {
        double CalculateShippingCost(Order order);
    }
}
