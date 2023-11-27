using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_strategy_patter_with_DI_factory.Services;

namespace simple_strategy_patter_with_DI_factory.Context
{
    // Context
    public class ShoppingCart
    {
        private readonly IPaymentService _paymentService;

        public ShoppingCart(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessPayment(double totalAmount)
        {
            // Processing payment using the selected strategy
            _paymentService.Pay(totalAmount);
        }
    }
}
