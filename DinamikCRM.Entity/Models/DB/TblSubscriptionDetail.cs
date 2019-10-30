using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblSubscriptionDetail
    {
        public int Id { get; set; }
        public string SubscriptionNumber { get; set; }
        public string CustomerNumber { get; set; }
        public string PackNumber { get; set; }
        public string PaymentNumber { get; set; }
        public string SalesNumber { get; set; }
        public int? PaymentTypeId { get; set; }
        public bool? IsPayment { get; set; }
        public double? Price { get; set; }
        public int? CurrencyId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
