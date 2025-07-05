using StrategyPatternExample.Abstract;
using StrategyPatternExample.Models;

namespace StrategyPatternExample.Concrete.Strategies
{
    public class AbcCargoStrategy : IShippingStrategy
    {
        public decimal CalculateShippingCost(OrderDto order)
        {
            return 30m; // Sabit fiyat
        }
    }
}
