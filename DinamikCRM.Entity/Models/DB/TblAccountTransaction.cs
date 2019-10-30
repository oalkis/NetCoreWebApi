using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblAccountTransaction
    {
        public int Id { get; set; }
        public int? RelatedDataId { get; set; }
        public string AccountNumber { get; set; }
        public int? ModuleId { get; set; }
        public string DataNumber { get; set; }
        public int? TypeId { get; set; }
        public double? Amount { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Description { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
