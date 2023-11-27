﻿using Microsoft.Extensions.DependencyInjection;
using simple_strategy_pattern_wth_DI.Context;
using simple_strategy_pattern_wth_DI.Services;

namespace simple_strategy_pattern_wth_DI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setup dependency injection
            var serviceProvider = new ServiceCollection()
                .AddTransient<Dictionary<string, IPaymentService>>(provider =>
                {
                    var strategies = new Dictionary<string, IPaymentService>
                    {
                        { "CreditCardPaymentService", new CreditCardPaymentService() },
                        { "PayPalPaymentService", new PayPalPaymentService() }
                    };

                    return strategies;
                })
                .BuildServiceProvider();

            var paymentStrategies = serviceProvider.GetRequiredService<Dictionary<string, IPaymentService>>();
            

            // Resolve the required services
            var creditCardPaymentService = paymentStrategies["CreditCardPaymentService"];
            var payPalPaymentService = paymentStrategies["PayPalPaymentService"];

            // Using strategies
            ShoppingCart cart = new ShoppingCart(creditCardPaymentService);
            cart.ProcessPayment(100.50); // Paying via Credit Card

            // Changing strategy at runtime
            cart = new ShoppingCart(payPalPaymentService);
            cart.ProcessPayment(75.20); // Paying via PayPal
        }
    }
}