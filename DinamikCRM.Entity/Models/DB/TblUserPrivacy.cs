using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblUserPrivacy
    {
        public int Id { get; set; }
        public bool? IsMailing { get; set; }
        public bool? IsPush { get; set; }
        public bool? IsSms { get; set; }
        public bool? IsPhone { get; set; }
        public bool? IsRemote { get; set; }
        public int? UserId { get; set; }
    }
}
