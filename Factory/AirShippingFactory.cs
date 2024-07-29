using System;
using System.Collections.Generic;
using MyShippingApi.Strategies;

namespace MyShippingApi.Factories
{
    public class AirShippingFactory : IShippingStrategyFactory
    {
        private readonly Dictionary<ShippingType, IShippingStrategy> _strategies = new Dictionary<ShippingType, IShippingStrategy>
        {
            { ShippingType.Standard, new AirStandardStrategy() },
            { ShippingType.Express, new AirExpressStrategy() }
        };

        public IShippingStrategy CreateStrategy(ShippingType type)
        {
            if (_strategies.TryGetValue(type, out var strategy))
            {
                return strategy;
            }
            throw new ArgumentException("Invalid shipping type for Air shipping");
        }
    }
}
