namespace CarnacodeAbstractFactory.Domain.Abstractions;

public interface IPaymentLogger
{
    Task Log(string message);
}