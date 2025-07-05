using StrategyPatternExample.Abstract;
using StrategyPatternExample.Models;

namespace StrategyPatternExample.Concrete
{
    public class ShippingCostCalculator
    {
        private readonly IShippingStrategy _strategy;

        public ShippingCostCalculator(IShippingStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal Calculate(OrderDto order)
        {
            return _strategy.CalculateShippingCost(order);
        }
    }
}
