using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblSmsprovider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PostUrl { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Originator { get; set; }
        public bool? IsDefault { get; set; }
        public int? SortOrder { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
