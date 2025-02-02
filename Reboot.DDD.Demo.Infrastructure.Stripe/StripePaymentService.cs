using Reboot.DDD.Demo.Domain.Entities;
using Reboot.DDD.Demo.Domain.Services;
using Reboot.DDD.Demo.Domain.ValueObjects;

namespace Reboot.DDD.Demo.Infrastructure.Stripe;
internal class StripePaymentService : IPaymentService
{
    public PaymentResponse ProcessPayment(Order order, PaymentInfo info)
    {
        Console.WriteLine("Processing payment with Stripe");

        return new PaymentResponse
        {
            IsSuccess = true,
            ErrorMessage = null
        };
    }
}
