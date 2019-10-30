using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblLogPage
    {
        public int Id { get; set; }
        public string Page { get; set; }
        public string Url { get; set; }
        public string ReferralUrl { get; set; }
        public string Result { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
