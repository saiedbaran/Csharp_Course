using System;

namespace Interfaces
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException("This order is already proceeded");
            }

            order.Shipment = new Shipment()
            {
                ShippingCost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}