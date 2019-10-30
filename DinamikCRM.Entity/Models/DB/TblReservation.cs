using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblReservation
    {
        public int Id { get; set; }
        public string ReservationNumber { get; set; }
        public int? TypeId { get; set; }
        public int? ModuleId { get; set; }
        public string DataNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Location { get; set; }
        public string Person { get; set; }
        public string Table { get; set; }
        public string Child { get; set; }
        public string Phone { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsCompleted { get; set; }
        public DateTime? ReservationDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
