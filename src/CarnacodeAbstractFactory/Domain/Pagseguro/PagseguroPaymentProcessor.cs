using CarnacodeAbstractFactory.Domain.Abstractions;

namespace CarnacodeAbstractFactory.Domain.Pagseguro;

public sealed class PagseguroPaymentProcessor: IPaymentProcessor
{
    public Task<string> ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"PagSeguro: Processando R$ {amount}...");
        
        return Task.FromResult($"PAGSEG-{Guid.NewGuid().ToString().Substring(0, 8)}");
    }
}