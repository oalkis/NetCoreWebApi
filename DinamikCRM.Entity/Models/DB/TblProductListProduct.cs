using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblProductListProduct
    {
        public int Id { get; set; }
        public int? ListId { get; set; }
        public string ProductNumber { get; set; }
        public double? Price { get; set; }
        public double? PriceMax { get; set; }
        public int? Currency { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
