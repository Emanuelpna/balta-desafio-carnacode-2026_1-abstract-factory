using CarnacodeAbstractFactory.Domain.Abstractions;

namespace CarnacodeAbstractFactory.Domain.Pagseguro;

public sealed class PagseguroPaymentProviderFactory : IPaymentProviderFactory
{
    public string ProviderName => "PagSeguro";

    public IPaymentValidator CreateValidator()
    {
        return new  PagseguroPaymentValidator();
    }

    public IPaymentProcessor CreateProcessor()
    {
        return new PagseguroPaymentProcessor();
    }

    public IPaymentLogger CreateLogger()
    {
        return new PagseguroPaymentLogger();
    }
}