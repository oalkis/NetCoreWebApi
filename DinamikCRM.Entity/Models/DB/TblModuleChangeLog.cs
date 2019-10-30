using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblModuleChangeLog
    {
        public int Id { get; set; }
        public int? ModuleId { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
