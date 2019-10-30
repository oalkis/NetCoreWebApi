using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblProposal
    {
        public int Id { get; set; }
        public string ProposalNumber { get; set; }
        public int? TypeId { get; set; }
        public int? DataTypeId { get; set; }
        public string DataNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public int? Currency { get; set; }
        public double? Tax { get; set; }
        public double? TotalPrice { get; set; }
        public string StartingText { get; set; }
        public string EndingText { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public bool? IsShared { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
