using Microsoft.Extensions.DependencyInjection;
using simple_strategy_patter_with_DI_factory.Context;
using simple_strategy_patter_with_DI_factory.Factories;
using simple_strategy_patter_with_DI_factory.Services;

namespace simple_strategy_patter_with_DI_factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setup dependency injection
            var serviceProvider = new ServiceCollection().AddSingleton<PaymentServicesFactory>().BuildServiceProvider();

            var factory = serviceProvider.GetRequiredService<PaymentServicesFactory>();

            factory.RegisterService(PaymentServices.CreditCard, () => new CreditCardPaymentService());
            factory.RegisterService(PaymentServices.PayPal, () => new PayPalPaymentService());

            // Resolve the required services
            var creditCardPaymentService = factory.GetService(PaymentServices.CreditCard);
            var payPalPaymentService = factory.GetService(PaymentServices.PayPal);

            // Using strategies
            ShoppingCart cart = new ShoppingCart(creditCardPaymentService);
            cart.ProcessPayment(100.50); // Paying via Credit Card

            // Changing strategy at runtime
            cart = new ShoppingCart(payPalPaymentService);
            cart.ProcessPayment(75.20); // Paying via PayPal
        }
    }
}