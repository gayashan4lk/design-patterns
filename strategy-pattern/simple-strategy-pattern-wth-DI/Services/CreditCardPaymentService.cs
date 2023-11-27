namespace simple_strategy_pattern_wth_DI.Services;

// Concrete strategies
public class CreditCardPaymentService : IPaymentService
{
	public void Pay(double amount)
	{
		Console.WriteLine($"Paying {amount} via Credit Card");
		// Additional logic specific to credit card payment
	}
}