using CarnacodeAbstractFactory.Domain.Abstractions;

namespace CarnacodeAbstractFactory.Domain.Stripe;

public class StripePaymentProviderFactory : IPaymentProviderFactory
{
    public string ProviderName => "Stripe";
    
    public IPaymentValidator CreateValidator()
    {
        return new StripePaymentValidator();
    }

    public IPaymentProcessor CreateProcessor()
    {
        return new StripePaymentProcessor();
    }

    public IPaymentLogger CreateLogger()
    {
        return new StripePaymentLogger();
    }
}