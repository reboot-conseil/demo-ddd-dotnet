
namespace Reboot.DDD.Demo.Api.Dto;

public class PayOrderResponse
{
    public int OrderId { get; set; }
    public decimal PaymentAmount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentCurrency { get; set; }
    public string PaymentMethod { get; set; }
}
