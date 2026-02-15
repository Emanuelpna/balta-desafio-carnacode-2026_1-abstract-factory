using CarnacodeAbstractFactory.Domain.Abstractions;
using CarnacodeAbstractFactory.Domain.MercadoPago;
using CarnacodeAbstractFactory.Domain.Pagseguro;
using CarnacodeAbstractFactory.Domain.Stripe;

namespace CarnacodeAbstractFactory.Application;

public static class PaymentProviderFactory
{
    public static IPaymentProviderFactory BuildPaymentProvider(string providerName)
    {
        return providerName switch
        {
            "PagSeguro" => new PagseguroPaymentProviderFactory(),
            "MercadoPago" => new MercadoPagoPaymentProviderFactory(),
            "Stripe" => new StripePaymentProviderFactory(),
            _ => throw new NotSupportedException($"Provider name {providerName} is not supported")
        };
    }
}