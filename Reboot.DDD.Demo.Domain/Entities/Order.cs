using System;
using System.Collections.Generic;

namespace Reboot.DDD.Demo.Domain.Entities;
public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; } = [];

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var item in OrderItems)
        {
            totalPrice += item.Quantity * item.UnitPrice;
        }
        return totalPrice;
    }
}
