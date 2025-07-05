using StrategyPatternExample.Models;

namespace StrategyPatternExample.Abstract
{
    public interface IShippingStrategy
    {
        decimal CalculateShippingCost(OrderDto order);
    }
}