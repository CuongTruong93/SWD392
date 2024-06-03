﻿using System;
using System.Collections.Generic;

namespace SWD392_Group3_Project.Entities
{
    public partial class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int MenuItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual MenuItem MenuItem { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
