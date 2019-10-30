using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblFormDetail
    {
        public int Id { get; set; }
        public string FormNumber { get; set; }
        public string LabelName { get; set; }
        public int? ElementType { get; set; }
        public int? MaxLength { get; set; }
        public bool? IsRequired { get; set; }
        public string MappedDbField { get; set; }
        public int? SortOrder { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
