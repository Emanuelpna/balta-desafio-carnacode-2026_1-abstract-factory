using CarnacodeAbstractFactory.Domain.Abstractions;

namespace CarnacodeAbstractFactory.Domain.MercadoPago;

public class MercadoPagoPaymentValidator : IPaymentValidator
{
    public Task<bool> ValidateCard(string cardNumber)
    {
        Console.WriteLine("MercadoPago: Validando cartão...");
        
        return Task.FromResult(cardNumber.Length == 16 && cardNumber.StartsWith('5'));
    }
}