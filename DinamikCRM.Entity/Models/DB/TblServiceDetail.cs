using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblServiceDetail
    {
        public int Id { get; set; }
        public string ServiceNumber { get; set; }
        public double? Price { get; set; }
        public int? Tax { get; set; }
        public int? Currency { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
