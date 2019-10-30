using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblContactPermit
    {
        public int Id { get; set; }
        public string ContactNumber { get; set; }
        public bool? Phone { get; set; }
        public bool? Sms { get; set; }
        public bool? Email { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
