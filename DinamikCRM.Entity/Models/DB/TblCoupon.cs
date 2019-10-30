using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblCoupon
    {
        public int Id { get; set; }
        public string CouponNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Action { get; set; }
        public int? Limit { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Active { get; set; }
    }
}
