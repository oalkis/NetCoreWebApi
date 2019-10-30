using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblReminder
    {
        public int Id { get; set; }
        public string ReminderNumber { get; set; }
        public int? TypeId { get; set; }
        public int? ModuleId { get; set; }
        public string DataNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? ReminderDate { get; set; }
        public bool? IsMuted { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
