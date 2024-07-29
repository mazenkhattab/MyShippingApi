using MyShippingApi.Strategies;
namespace MyShippingApi.Factories
{
    public interface IShippingStrategyFactory
    {
        IShippingStrategy CreateStrategy(ShippingType type);
    }
}
