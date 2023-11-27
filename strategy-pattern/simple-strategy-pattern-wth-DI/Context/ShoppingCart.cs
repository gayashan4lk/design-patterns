using simple_strategy_pattern_wth_DI.Services;

namespace simple_strategy_pattern_wth_DI.Context
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
