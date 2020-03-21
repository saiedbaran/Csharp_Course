using System;

namespace Interfaces
{
    public class Order
    {
        public float TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public Shipment Shipment { get; set; }
        public bool IsShipped { get; set; }

    }

    public class Shipment
    {
        public float ShippingCost { get; set; }
        public DateTime ShippingDate { get; set; }
    }

}