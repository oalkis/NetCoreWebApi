using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblSalesPayment
    {
        public int Id { get; set; }
        public string PaymentNumber { get; set; }
        public string SalesNumber { get; set; }
        public string DataNumber { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool? IsRead { get; set; }
        public bool? IsPay { get; set; }
        public DateTime? ExpireDate { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
