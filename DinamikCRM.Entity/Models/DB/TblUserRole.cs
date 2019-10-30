using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblUserRole
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ModuleId { get; set; }
        public bool? IsSelect { get; set; }
        public bool? IsCreate { get; set; }
        public bool? IsUpdate { get; set; }
        public bool? IsDelete { get; set; }
    }
}
