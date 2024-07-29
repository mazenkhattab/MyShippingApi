using System;
using System.Collections.Generic;

namespace MyShippingApi.Factories
{
    public class ShippingFactoryProvider
    {
        private readonly Dictionary<ShippingMethod, IShippingStrategyFactory> _factories;

        public ShippingFactoryProvider(AirShippingFactory airShippingFactory)
        {
            _factories = new Dictionary<ShippingMethod, IShippingStrategyFactory>
            {
                { ShippingMethod.Air, airShippingFactory },
             
            };
        }

        public IShippingStrategyFactory GetFactory(ShippingMethod method)
        {
            if (_factories.TryGetValue(method, out var factory))
            {
                return factory;
            }
            throw new ArgumentException("Invalid shipping method");
        }
    }
}
