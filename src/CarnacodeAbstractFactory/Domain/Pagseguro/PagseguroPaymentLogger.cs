using CarnacodeAbstractFactory.Domain.Abstractions;

namespace CarnacodeAbstractFactory.Domain.Pagseguro;

public class PagseguroPaymentLogger : IPaymentLogger
{
    public Task Log(string message)
    {
        Console.WriteLine($"[PagSeguro Log] {DateTime.Now}: {message}");

        return Task.CompletedTask;
    }
}