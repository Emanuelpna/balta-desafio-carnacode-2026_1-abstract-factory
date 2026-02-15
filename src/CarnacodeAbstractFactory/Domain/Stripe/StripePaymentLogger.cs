using CarnacodeAbstractFactory.Domain.Abstractions;

namespace CarnacodeAbstractFactory.Domain.Stripe;

public class StripePaymentLogger : IPaymentLogger
{
    public Task Log(string message)
    {
        Console.WriteLine($"[Stripe Log] {DateTime.Now}: {message}");

        return Task.CompletedTask;
    }
}