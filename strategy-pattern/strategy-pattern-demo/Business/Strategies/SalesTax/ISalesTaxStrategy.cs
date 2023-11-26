using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using strategy_pattern_demo.Business.Models;

namespace strategy_pattern_demo.Business.Strategies.SalesTax
{
    public interface ISalesTaxStrategy
    {
        public decimal GetTax(Order order);
    }
}
