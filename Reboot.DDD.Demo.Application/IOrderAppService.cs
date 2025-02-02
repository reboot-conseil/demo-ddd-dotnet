using Reboot.DDD.Demo.Api.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reboot.DDD.Demo.Application;
public interface IOrderAppService
{
    Task<PayOrderResponse> ProcessOrderPayment(PayOrderRequest order);
}
