using CarnacodeAbstractFactory.Domain.Abstractions;

namespace CarnacodeAbstractFactory.Application;

public sealed class PaymentService(IPaymentProviderFactory paymentProviderFactory)
{
    public async Task<bool> ProcessPayment(decimal amount, string cardNumber)
    {
        var paymentValidator = paymentProviderFactory.CreateValidator();
        if (!await paymentValidator.ValidateCard(cardNumber))
        {
            Console.WriteLine($"{paymentProviderFactory.ProviderName}: Cartão inválido");
            return false;
        }
                    
        var paymentProcessor = paymentProviderFactory.CreateProcessor();
        var transaction = await paymentProcessor.ProcessTransaction(amount, cardNumber);

        var paymentLogger = paymentProviderFactory.CreateLogger();
        await paymentLogger.Log($"Transação processada: {transaction}");

        return true;
    }
}