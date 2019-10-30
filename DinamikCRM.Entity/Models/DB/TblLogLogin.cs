using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblLogLogin
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string ReferralUrl { get; set; }
        public string Result { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
