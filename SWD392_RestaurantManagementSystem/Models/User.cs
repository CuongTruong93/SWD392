using System;
using System.Collections.Generic;

namespace SWD392_RestaurantManagementSystem.Models;

public partial class User
{
    public int UserId { get; set; }

    public int RoleId { get; set; }

    public string Username { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateOnly? CreatedAt { get; set; }

    public virtual ICollection<BillingInfo> BillingInfos { get; set; } = new List<BillingInfo>();

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();

    public virtual ICollection<Reservation> ReservationAdmins { get; set; } = new List<Reservation>();

    public virtual ICollection<Reservation> ReservationCustomers { get; set; } = new List<Reservation>();

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
