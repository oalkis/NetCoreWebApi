using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblNpsData
    {
        public int Id { get; set; }
        public string NpsNumber { get; set; }
        public string DataNumber { get; set; }
        public int? Point { get; set; }
        public string Comment { get; set; }
        public string ManagerComment { get; set; }
        public int? Flag { get; set; }
        public bool? IsRead { get; set; }
        public int? GroupId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
