using CarnacodeAbstractFactory.Domain.Abstractions;

namespace CarnacodeAbstractFactory.Domain.MercadoPago;

public class MercadoPagoPaymentLogger : IPaymentLogger
{
    public Task Log(string message)
    {
        Console.WriteLine($"[MercadoPago Log] {DateTime.Now}: {message}");

        return Task.CompletedTask;
    }
}