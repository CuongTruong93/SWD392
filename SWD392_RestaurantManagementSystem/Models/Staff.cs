using System;
using System.Collections.Generic;

namespace SWD392_RestaurantManagementSystem.Models;

public partial class Staff
{
    public int StaffId { get; set; }

    public int UserId { get; set; }

    public string? Position { get; set; }

    public decimal? Salary { get; set; }

    public DateOnly? HireDate { get; set; }

    public virtual User User { get; set; } = null!;
}
