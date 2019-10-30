using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblContentComment
    {
        public int Id { get; set; }
        public string ContentNumber { get; set; }
        public int? DataTypeId { get; set; }
        public string DataNumber { get; set; }
        public string Comment { get; set; }
        public int? Rating { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
