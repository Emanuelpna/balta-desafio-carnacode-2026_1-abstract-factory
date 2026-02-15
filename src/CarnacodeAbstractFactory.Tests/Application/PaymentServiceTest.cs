using System;
using System.Threading.Tasks;
using CarnacodeAbstractFactory.Application;
using Xunit;

namespace CarnacodeAbstractFactory.Tests.Application;

public class PaymentServiceTest
{
    [Fact]
    public async Task ShouldNotProcessPaymentWithInvalidProvider()
    {
        await Assert.ThrowsAsync<NotSupportedException>(async () =>
        {
            var pagseguroPayment = new PaymentService(PaymentProviderFactory.BuildPaymentProvider("MyProvider"));
            await pagseguroPayment.ProcessPayment(150.00m, "1234567890123456");

        });
    }
    
    [Fact]
    public async Task ShouldProcessPaymentWithPagSeguro()
    {
        var pagseguroPayment = new PaymentService(PaymentProviderFactory.BuildPaymentProvider("PagSeguro"));
        var result = await pagseguroPayment.ProcessPayment(150.00m, "1234567890123456");
        
        Assert.True(result);
    }
    
    [Fact]
    public async Task ShouldProcessPaymentWithMercadoPago()
    {
        var mercadoPagoService = new PaymentService(PaymentProviderFactory.BuildPaymentProvider("MercadoPago"));
        var result = await mercadoPagoService.ProcessPayment(200.00m, "5234567890123456");
        
        Assert.True(result);
    }
    
    [Fact]
    public async Task ShouldNotProcessPaymentWithMercadoPagoWithInvalidCardNumber()
    {
        var mercadoPagoService = new PaymentService(PaymentProviderFactory.BuildPaymentProvider("MercadoPago"));
        var result = await mercadoPagoService.ProcessPayment(200.00m, "1234567890123456");
        
        Assert.False(result);
    }
    
    [Fact]
    public async Task ShouldProcessPaymentWithStripe()
    {
        var mercadoPagoService = new PaymentService(PaymentProviderFactory.BuildPaymentProvider("Stripe"));
        var result = await mercadoPagoService.ProcessPayment(200.00m, "4234567890123456");
        
        Assert.True(result);
    }
    
    [Fact]
    public async Task ShouldNotProcessPaymentWithStripeWithInvalidCardNumber()
    {
        var mercadoPagoService = new PaymentService(PaymentProviderFactory.BuildPaymentProvider("Stripe"));
        var result = await mercadoPagoService.ProcessPayment(200.00m, "1234567890123456");
        
        Assert.False(result);
    }
}