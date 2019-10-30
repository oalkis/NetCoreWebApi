using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblUserModule
    {
        public int Id { get; set; }
        public int? ModuleId { get; set; }
        public int? UserId { get; set; }
    }
}
