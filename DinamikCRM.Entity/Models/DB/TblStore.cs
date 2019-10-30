﻿using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblStore
    {
        public int Id { get; set; }
        public string ItemNumber { get; set; }
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public double? DiscountedPrice { get; set; }
        public int? CurrencyId { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsCampaign { get; set; }
        public DateTime? ExpireDate { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
