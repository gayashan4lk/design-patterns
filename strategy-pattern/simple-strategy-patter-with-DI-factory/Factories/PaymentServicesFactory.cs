using simple_strategy_patter_with_DI_factory.Services;

namespace simple_strategy_patter_with_DI_factory.Factories;

public class PaymentServicesFactory
{
	private readonly Dictionary<PaymentServices, Func<IPaymentService>> _paymentServices;

	public PaymentServicesFactory()
	{
		_paymentServices = new Dictionary<PaymentServices, Func<IPaymentService>>();
	}

	public void RegisterService(PaymentServices paymentServiceName, Func<IPaymentService> paymentService)
	{
		_paymentServices.Add(paymentServiceName, paymentService);
	}

	public IPaymentService GetService(PaymentServices paymentServiceName)
	{
		// return _paymentServices[paymentServiceName]();

		if (_paymentServices.TryGetValue(paymentServiceName, out var service))
		{
			return service();
		}

		throw new KeyNotFoundException($"Payment service {paymentServiceName} is not registered");
	}
}