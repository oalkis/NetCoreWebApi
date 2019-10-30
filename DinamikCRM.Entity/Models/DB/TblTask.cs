using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblTask
    {
        public int Id { get; set; }
        public string TaskNumber { get; set; }
        public int? TypeId { get; set; }
        public int? ProjectId { get; set; }
        public int? FromId { get; set; }
        public int? ToId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Deadline { get; set; }
        public int? Priority { get; set; }
        public int? CompletionRate { get; set; }
        public bool? IsClose { get; set; }
        public bool? IsShared { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
