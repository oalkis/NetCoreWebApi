using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblLogSms
    {
        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public int? ModuleId { get; set; }
        public string DataNumber { get; set; }
        public string Phone { get; set; }
        public string Body { get; set; }
        public string Result { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
