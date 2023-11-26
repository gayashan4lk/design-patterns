using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using strategy_pattern_demo.Business.Models;

namespace strategy_pattern_demo.Business.Strategies.SalesTax
{
    public class USASalesTaxStrategy : ISalesTaxStrategy
    {
        public decimal GetTax(Order order)
        {
            switch (order.ShippingDetails.DestinationState.ToLowerInvariant())
            {
                case "la": return order.TotalPrice * 0.095m;
                case "ny": return order.TotalPrice * 0.04m;
                case "nyc": return order.TotalPrice * 0.045m;
                default: return 0m;
            }
        }
    }
}
