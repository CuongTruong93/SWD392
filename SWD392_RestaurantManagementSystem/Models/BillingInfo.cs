using System;
using System.Collections.Generic;

namespace SWD392_RestaurantManagementSystem.Models;

public partial class BillingInfo
{
    public int BillingId { get; set; }

    public int OrderId { get; set; }

    public int CashierId { get; set; }

    public DateOnly? BillingDate { get; set; }

    public decimal Amount { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public virtual User Cashier { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
