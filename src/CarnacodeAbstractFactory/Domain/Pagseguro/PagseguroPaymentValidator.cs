using CarnacodeAbstractFactory.Domain.Abstractions;

namespace CarnacodeAbstractFactory.Domain.Pagseguro;

public class PagseguroPaymentValidator : IPaymentValidator
{
    public Task<bool> ValidateCard(string cardNumber)
    {
        Console.WriteLine("PagSeguro: Validando cartão...");
        
        return Task.FromResult(cardNumber.Length == 16);
    }
}