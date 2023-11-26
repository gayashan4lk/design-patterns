namespace strategy_pattern_demo.Business.Models
{
    public enum ShippingStatus
    {
        WaitingForPayment,
        ReadyForShipment,
        Shipped
    }

    public enum PaymentProvider
    {
        Paypal,
        CreditCard,
        Invoice
    }

    public enum ItemType
    {
        Service,
        Food,
        Hardware,
        Literature
    }
}
