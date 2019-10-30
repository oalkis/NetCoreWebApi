using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblOrderDetail
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public int? Quantity { get; set; }
        public double? UnitPrice { get; set; }
        public double? SubTotalPrice { get; set; }
        public int? TaxRate { get; set; }
        public double? Tax { get; set; }
        public double? TotalPrice { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
