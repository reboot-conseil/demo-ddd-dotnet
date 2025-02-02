namespace Reboot.DDD.Demo.Domain.ValueObjects;

public class PaymentResponse
{
    public bool IsSuccess { get; set; }

    public string? ErrorMessage { get; set; }
}
