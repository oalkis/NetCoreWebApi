﻿using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblTaskResponsible
    {
        public int Id { get; set; }
        public string TaskNumber { get; set; }
        public int? ResponsibleId { get; set; }
        public string Description { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
