using System;
using System.Collections.Generic;

namespace SWD392_Group3_Project.Entities
{
    public partial class User
    {
        public User()
        {
            BillingInfos = new HashSet<BillingInfo>();
            Employees = new HashSet<Employee>();
            Feedbacks = new HashSet<Feedback>();
            Orders = new HashSet<Order>();
            Profiles = new HashSet<Profile>();
            ReservationAdmins = new HashSet<Reservation>();
            ReservationCustomers = new HashSet<Reservation>();
        }

        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Username { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<BillingInfo> BillingInfos { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
        public virtual ICollection<Reservation> ReservationAdmins { get; set; }
        public virtual ICollection<Reservation> ReservationCustomers { get; set; }
    }
}
