namespace simple_strategy_pattern_wth_DI.Services
{
    // Strategy interface
    public interface IPaymentService
    {
        void Pay(double amount);
    }

    // Concrete strategies are
    // PayPalPaymentService and CreditCardPaymentService
}
