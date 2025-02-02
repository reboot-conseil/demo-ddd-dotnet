using Reboot.DDD.Demo.Domain.Entities;
using Reboot.DDD.Demo.Domain.ValueObjects;

namespace Reboot.DDD.Demo.Domain.Services;
public interface IPaymentService
{
    PaymentResponse ProcessPayment(Order order, PaymentInfo info);
}
