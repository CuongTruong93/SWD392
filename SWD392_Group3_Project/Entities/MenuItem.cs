using System;
using System.Collections.Generic;

namespace SWD392_Group3_Project.Entities
{
    public partial class MenuItem
    {
        public MenuItem()
        {
            OrderItems = new HashSet<OrderItem>();
            Recipes = new HashSet<Recipe>();
        }

        public int MenuItemId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? Category { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
