namespace simple_strategy_pattern
{
    // Strategy interface
    public interface IPaymentStrategy
    {
        void Pay(double amount);
    }

    // Concrete strategies
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paying {amount} via Credit Card");
            // Additional logic specific to credit card payment
        }
    }

    public class PayPalPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paying {amount} via PayPal");
            // Additional logic specific to PayPal payment
        }
    }

    // Context
    public class ShoppingCart
    {
        private readonly IPaymentStrategy _paymentStrategy;

        public ShoppingCart(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(double totalAmount)
        {
            // Processing payment using the selected strategy
            _paymentStrategy.Pay(totalAmount);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating payment strategies
            IPaymentStrategy payPalPayment = new PayPalPaymentStrategy();
            IPaymentStrategy creditCardPayment = new CreditCardPaymentStrategy();

            // Using strategies in the context
            ShoppingCart cart = new ShoppingCart(creditCardPayment);
            cart.ProcessPayment(100.50); // Paying via Credit Card

            // Changing strategy at runtime
            cart = new ShoppingCart(payPalPayment);
            cart.ProcessPayment(75.20); // Paying via PayPal
        }
    }
}