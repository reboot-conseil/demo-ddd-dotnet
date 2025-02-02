
namespace Reboot.DDD.Demo.Api.Dto;

public class PayOrderResponse
{
    public int OrderId { get; set; }
    public string PaymentId { get; set; }
    public string PaymentStatus { get; set; }
    public string PaymentMethod { get; set; }
    public decimal PaymentAmount { get; set; }
    public string PaymentCurrency { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentDescription { get; set; }
    public string PaymentReceiptUrl { get; set; }
    public string PaymentFailureReason { get; set; }
    public string PaymentFailureCode { get; set; }
    public string PaymentFailureMessage { get; set; }
}
