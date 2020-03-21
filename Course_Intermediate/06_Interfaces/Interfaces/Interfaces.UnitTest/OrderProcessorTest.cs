using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interfaces;

namespace Interfaces.UnitTest
{
    [TestClass]
    public class OrderProcessorTest
    {
        // MethodName_Condition_Expectation

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_IsAlreadyShipped_ThrowAnException()
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order()
            {
                IsShipped = true
            };

            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1,order.Shipment.ShippingCost);
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
