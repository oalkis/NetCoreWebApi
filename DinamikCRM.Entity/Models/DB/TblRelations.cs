using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblRelations
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? ModuleIdFrom { get; set; }
        public string DataNumberFrom { get; set; }
        public int? ModuleIdTo { get; set; }
        public string DataNumberTo { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
