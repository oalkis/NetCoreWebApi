using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblUserDetail
    {
        public int Id { get; set; }
        public int? Segment { get; set; }
        public int? Language { get; set; }
        public int? Department { get; set; }
        public int? Team { get; set; }
        public string Ip { get; set; }
        public int? UserId { get; set; }
    }
}
