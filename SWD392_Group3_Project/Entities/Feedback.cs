using System;
using System.Collections.Generic;

namespace SWD392_Group3_Project.Entities
{
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public int? Rating { get; set; }
        public string? Comments { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual User Customer { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
