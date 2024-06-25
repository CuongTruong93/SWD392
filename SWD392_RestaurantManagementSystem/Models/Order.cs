using System;
using System.Collections.Generic;

namespace SWD392_RestaurantManagementSystem.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public DateOnly? OrderDate { get; set; }

    public bool Status { get; set; }

    public decimal? TotalAmount { get; set; }

    public virtual ICollection<BillingInfo> BillingInfos { get; set; } = new List<BillingInfo>();

    public virtual User Customer { get; set; } = null!;

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
