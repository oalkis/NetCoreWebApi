using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblGroupBanking
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string AccountOwner { get; set; }
        public string AccountNumber { get; set; }
        public string Iban { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
