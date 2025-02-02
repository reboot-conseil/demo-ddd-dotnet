using Reboot.DDD.Demo.Api.Dto;
using Reboot.DDD.Demo.Domain.Services;
using Reboot.DDD.Demo.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reboot.DDD.Demo.Application;
internal class OrderAppService(IOrderService orderService) : IOrderAppService
{
    public async Task<PayOrderResponse> ProcessOrderPayment(PayOrderRequest order)
    {
        Console.WriteLine($"Checking validity of request");

        var paymentInfo = new PaymentInfo
        {
            CardHolderName = order.CardHolderName,
            CardNumber = order.CardNumber,
            ExpiryDate = order.CardExpiryDate,
            CVV = order.CardCvv
        };
        await orderService.PayOrderAsync(order.OrderId, paymentInfo);

        Console.WriteLine($"Send email to customer");
        Console.WriteLine($"Send notifications");

        return new PayOrderResponse
        {
            OrderId = order.OrderId,
            PaymentAmount = order.Amount,
            PaymentCurrency = order.Currency,
            PaymentMethod = order.PaymentMethod,
            PaymentDate = DateTime.UtcNow
        };
    }
}
