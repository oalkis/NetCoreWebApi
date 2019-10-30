using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblUserSubscription
    {
        public int Id { get; set; }
        public int? PlanId { get; set; }
        public int? UserId { get; set; }
        public int? Luser { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Active { get; set; }
    }
}
