using CarnacodeAbstractFactory.Domain.Abstractions;

namespace CarnacodeAbstractFactory.Domain.MercadoPago;

public class MercadoPagoPaymentProcessor : IPaymentProcessor
{
    public Task<string> ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"MercadoPago: Processando R$ {amount}...");
        
        return Task.FromResult($"MP-{Guid.NewGuid().ToString().Substring(0, 8)}");
    }
}