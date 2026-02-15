using CarnacodeAbstractFactory.Domain.Abstractions;

namespace CarnacodeAbstractFactory.Domain.MercadoPago;

public class MercadoPagoPaymentProviderFactory: IPaymentProviderFactory
{
    public string ProviderName => "MercadoPago";
    
    public IPaymentValidator CreateValidator()
    {
        return new MercadoPagoPaymentValidator();
    }

    public IPaymentProcessor CreateProcessor()
    {
        return new  MercadoPagoPaymentProcessor();
    }

    public IPaymentLogger CreateLogger()
    {
        return new  MercadoPagoPaymentLogger();
    }
}