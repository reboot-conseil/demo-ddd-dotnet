using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reboot.DDD.Demo.Api.Dto;
public class PayOrderRequest
{
    public int OrderId { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; }
    public string PaymentMethod { get; set; }
    public string CardNumber { get; set; }
    public string CardHolderName { get; set; }
    public DateTime CardExpiryDate { get; set; }
    public string CardCvv { get; set; }
}
