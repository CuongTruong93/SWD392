using System;
using System.Collections.Generic;

namespace SWD392_RestaurantManagementSystem.Models;

public partial class Recipe
{
    public int RecipeId { get; set; }

    public int MenuItemId { get; set; }

    public string? Instructions { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public virtual MenuItem MenuItem { get; set; } = null!;
}
