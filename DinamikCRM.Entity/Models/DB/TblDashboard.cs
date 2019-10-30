using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblDashboard
    {
        public int Id { get; set; }
        public int? ModuleId { get; set; }
        public string Name { get; set; }
        public string ControlName { get; set; }
    }
}
