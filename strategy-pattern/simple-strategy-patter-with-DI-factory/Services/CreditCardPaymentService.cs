using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_strategy_patter_with_DI_factory.Services
{
    // Concrete strategies
    public class CreditCardPaymentService : IPaymentService
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paying {amount} via Credit Card");
            // Additional logic specific to credit card payment
        }
    }
}
