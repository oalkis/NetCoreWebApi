using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblCouponData
    {
        public int Id { get; set; }
        public int? CouponId { get; set; }
        public string CouponNumber { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
