﻿using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblSubscriptionPack
    {
        public int Id { get; set; }
        public string PackNumber { get; set; }
        public int? TypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public int? CurrencyId { get; set; }
        public int? Recurrence { get; set; }
        public int? RecurrenceType { get; set; }
        public int? RecurrenceCount { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
