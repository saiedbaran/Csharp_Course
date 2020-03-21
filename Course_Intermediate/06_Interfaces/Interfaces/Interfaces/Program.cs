using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var shippingCalculator = new ShippingCalculator();
            var orderProcessor = new OrderProcessor(shippingCalculator);

            var order = new Order(){TotalPrice = 100f};
            orderProcessor.Process(order);
        }
    }
}
