using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_strategy_patter_with_DI_factory.Services
{
    // Strategy interface
    public interface IPaymentService
    {
        void Pay(double amount);
    }

    // Concrete strategies are
    // PayPalPaymentService and CreditCardPaymentService
}
