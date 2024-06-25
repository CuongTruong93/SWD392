using System;
using System.Collections.Generic;

namespace SWD392_RestaurantManagementSystem.Models;

public partial class Reservation
{
    public int ReservationId { get; set; }

    public int AdminId { get; set; }

    public int CustomerId { get; set; }

    public DateOnly ReservationDate { get; set; }

    public int NumberOfGuests { get; set; }

    public bool Status { get; set; }

    public virtual User Admin { get; set; } = null!;

    public virtual User Customer { get; set; } = null!;
}
