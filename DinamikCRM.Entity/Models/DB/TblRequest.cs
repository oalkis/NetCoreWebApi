﻿using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblRequest
    {
        public int Id { get; set; }
        public string RequestNumber { get; set; }
        public string FormNumber { get; set; }
        public int? ModuleId { get; set; }
        public string DataNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime? Date { get; set; }
        public string Service { get; set; }
        public string Language { get; set; }
        public string Note { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
        public string Param3 { get; set; }
        public string Param4 { get; set; }
        public string Param5 { get; set; }
        public int? ResponsibleId { get; set; }
        public int? ResponseId { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
