using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string Description { get; set; }
        public string DescriptionEn { get; set; }
        public int? PeriodType { get; set; }
        public double? Price { get; set; }
        public double? PriceEn { get; set; }
        public bool? IsBuyable { get; set; }
        public bool? Active { get; set; }
    }
}
