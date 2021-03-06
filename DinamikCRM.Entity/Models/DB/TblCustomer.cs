﻿using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblCustomer
    {
        public int Id { get; set; }
        public string CustomerNumber { get; set; }
        public int? TypeId { get; set; }
        public int? SourceId { get; set; }
        public int? ProjectId { get; set; }
        public int? CompanyId { get; set; }
        public int? SectorId { get; set; }
        public int? SegmentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool? IsShared { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
