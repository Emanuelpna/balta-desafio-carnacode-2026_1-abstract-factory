namespace CarnacodeAbstractFactory.Domain.Abstractions;

public interface IPaymentProcessor
{
    Task<string> ProcessTransaction(decimal amount, string cardNumber);
}