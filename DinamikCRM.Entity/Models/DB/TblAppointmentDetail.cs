using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblAppointmentDetail
    {
        public int Id { get; set; }
        public string AppointmentNumber { get; set; }
        public int? ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
