using Reboot.DDD.Demo.Domain.Repositories;
using Reboot.DDD.Demo.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reboot.DDD.Demo.Domain.Services;
internal class OrderService(IPaymentService paymentService, IOrderRepository orderRepository) : IOrderService
{
    public async Task PayOrderAsync(int orderId, PaymentInfo info)
    {
        var order = await orderRepository.GetByIdAsync(orderId);

        if (order == null)
        {
            throw new ArgumentException("Order not found");
        }

        Console.WriteLine($"Verifying order status");

        var paymentResponse = paymentService.ProcessPayment(order, info);

        Console.WriteLine("Sending event to Stock domain");
        Console.WriteLine("Sending event to Comptability domain");

        // send other events, and manage state
    }
}
