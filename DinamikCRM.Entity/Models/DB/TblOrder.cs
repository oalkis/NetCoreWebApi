using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblOrder
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public int? CustomerId { get; set; }
        public int? DealerId { get; set; }
        public double? Price { get; set; }
        public double? Tax { get; set; }
        public double? TotalPrice { get; set; }
        public int? LastHistoryId { get; set; }
        public int? PaymentAddressId { get; set; }
        public int? ShippingAddressId { get; set; }
        public int? PaymentTypeId { get; set; }
        public int? ShippingTypeId { get; set; }
        public int? CreditId { get; set; }
        public bool? IsComplete { get; set; }
        public string Note { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
