using Reboot.DDD.Demo.Domain.Entities;
using Reboot.DDD.Demo.Domain.Services;
using Reboot.DDD.Demo.Domain.ValueObjects;

namespace Reboot.DDD.Demo.Infrastructure.Paypal;
internal class PaypalPaymentService : IPaymentService
{
    public PaymentResponse ProcessPayment(Order order, PaymentInfo info)
    {
        Console.WriteLine("Processing payment with Paypal");

        return new PaymentResponse
        {
            IsSuccess = false,
            ErrorMessage = "Paypal is broken"
        };
    }
}
