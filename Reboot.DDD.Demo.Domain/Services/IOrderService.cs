using Reboot.DDD.Demo.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reboot.DDD.Demo.Domain.Services;
public interface IOrderService
{
    Task PayOrderAsync(int orderId, PaymentInfo info);
}
