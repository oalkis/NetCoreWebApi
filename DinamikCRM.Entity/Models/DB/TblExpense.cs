using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblExpense
    {
        public int Id { get; set; }
        public string ExpenseNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public int? VendorId { get; set; }
        public DateTime? ExpenseDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public double? Price { get; set; }
        public int? Tax { get; set; }
        public int? Currency { get; set; }
        public int? StatusId { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
