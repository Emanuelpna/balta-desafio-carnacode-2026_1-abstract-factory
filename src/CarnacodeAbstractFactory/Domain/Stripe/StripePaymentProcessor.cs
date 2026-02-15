using CarnacodeAbstractFactory.Domain.Abstractions;

namespace CarnacodeAbstractFactory.Domain.Stripe;

public class StripePaymentProcessor : IPaymentProcessor
{
    public Task<string> ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"Stripe: Processando R$ {amount}...");
        
        return Task.FromResult($"STRIPE-{Guid.NewGuid().ToString().Substring(0, 8)}");
    }
}