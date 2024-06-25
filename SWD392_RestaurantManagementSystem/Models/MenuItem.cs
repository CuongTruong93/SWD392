using System;
using System.Collections.Generic;

namespace SWD392_RestaurantManagementSystem.Models;

public partial class MenuItem
{
    public int MenuItemId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public string? Category { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
