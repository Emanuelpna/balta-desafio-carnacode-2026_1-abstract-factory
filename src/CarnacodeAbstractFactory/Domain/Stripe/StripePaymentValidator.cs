using CarnacodeAbstractFactory.Domain.Abstractions;

namespace CarnacodeAbstractFactory.Domain.Stripe;

public class StripePaymentValidator : IPaymentValidator
{
    public Task<bool> ValidateCard(string cardNumber)
    {
        Console.WriteLine("Stripe: Validando cartão...");
        
        return Task.FromResult(cardNumber.Length == 16 && cardNumber.StartsWith('4'));
    }
}