using StrategyPatternExample.Abstract;
using StrategyPatternExample.Models;

namespace StrategyPatternExample.Concrete.Strategies
{
    public class XyzCargoStrategy : IShippingStrategy
    {
        public decimal CalculateShippingCost(OrderDto order)
        {
            return 10m + order.Weight * 1.0m + order.Distance * 0.5m;
        }
    }
}