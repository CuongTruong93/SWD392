using System;
using System.Collections.Generic;

namespace SWD392_Group3_Project.Entities
{
    public partial class Order
    {
        public Order()
        {
            BillingInfos = new HashSet<BillingInfo>();
            Feedbacks = new HashSet<Feedback>();
            OrderItems = new HashSet<OrderItem>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public bool Status { get; set; }
        public decimal? TotalAmount { get; set; }

        public virtual User Customer { get; set; } = null!;
        public virtual ICollection<BillingInfo> BillingInfos { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
