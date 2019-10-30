﻿using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblActivity
    {
        public int Id { get; set; }
        public string ActivityNumber { get; set; }
        public int? ModuleId { get; set; }
        public string DataNumber { get; set; }
        public int? TypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? PriorityId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsShared { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
