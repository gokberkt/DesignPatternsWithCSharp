using StrategyPatternExample.Concrete;
using StrategyPatternExample.Concrete.Strategies;
using StrategyPatternExample.Models;

namespace StrategyPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new OrderDto { Weight = 10, Distance = 100 };

            var abcCargoCost = new ShippingCostCalculator(new AbcCargoStrategy()).Calculate(order);
            var xyzCargoCost = new ShippingCostCalculator(new XyzCargoStrategy()).Calculate(order);
            var aresCargoCost = new ShippingCostCalculator(new AresCargoStrategy()).Calculate(order);

            Console.WriteLine($"ABC Kargo Ücreti: {abcCargoCost} TL");
            Console.WriteLine($"XYZ Kargo Ücreti: {xyzCargoCost} TL");
            Console.WriteLine($"ARES Kargo Ücreti: {aresCargoCost} TL");

            Console.ReadLine();
        }
    }
}