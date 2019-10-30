using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblNpsList
    {
        public int Id { get; set; }
        public int? ModuleId { get; set; }
        public string RecordNumber { get; set; }
        public string DataNumber { get; set; }
        public string NpsNumber { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? IsDelivered { get; set; }
        public bool? IsViewed { get; set; }
        public bool? IsParticipated { get; set; }
        public int? GroupId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
