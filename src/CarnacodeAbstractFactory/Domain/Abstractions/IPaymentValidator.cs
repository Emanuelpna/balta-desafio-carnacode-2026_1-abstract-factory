namespace CarnacodeAbstractFactory.Domain.Abstractions;

public interface IPaymentValidator
{
    Task<bool> ValidateCard(string cardNumber);
}