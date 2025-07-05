using StrategyPatternExample.Abstract;
using StrategyPatternExample.Models;

namespace StrategyPatternExample.Concrete.Strategies
{
    public class AresCargoStrategy : IShippingStrategy
    {
        public decimal CalculateShippingCost(OrderDto order)
        {
            return 5m + order.Weight * 1.2m;
        }
    }
}
