using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblStoreOrder
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public string ItemNumber { get; set; }
        public string ItemName { get; set; }
        public string GroupName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
        public double? Price { get; set; }
        public int? CurrencyId { get; set; }
        public bool? IsApprove { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
