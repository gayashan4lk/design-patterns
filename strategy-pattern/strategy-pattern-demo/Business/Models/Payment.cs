using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy_pattern_demo.Business.Models
{
    public class Payment
    {
        public decimal Amount { get; set; }
        public PaymentProvider PaymentProvider { get; set; }
    }
}
