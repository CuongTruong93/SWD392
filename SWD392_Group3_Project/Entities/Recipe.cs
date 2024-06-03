using System;
using System.Collections.Generic;

namespace SWD392_Group3_Project.Entities
{
    public partial class Recipe
    {
        public int RecipeId { get; set; }
        public int MenuItemId { get; set; }
        public string? Instructions { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual MenuItem MenuItem { get; set; } = null!;
    }
}
