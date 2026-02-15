namespace CarnacodeAbstractFactory.Domain.Abstractions;

public interface IPaymentProviderFactory
{
    string ProviderName { get; }
    
    IPaymentValidator CreateValidator();
    IPaymentProcessor CreateProcessor();
    IPaymentLogger CreateLogger();
}