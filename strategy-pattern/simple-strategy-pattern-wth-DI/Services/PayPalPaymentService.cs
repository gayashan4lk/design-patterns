namespace simple_strategy_pattern_wth_DI.Services;

// Concrete strategies
public class PayPalPaymentService : IPaymentService
{

	public void Pay(double amount)
	{
		Console.WriteLine($"Paying {amount} via PayPal");
		// Additional logic specific to PayPal payment
	}
}