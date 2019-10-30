using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblUserDashboard
    {
        public int Id { get; set; }
        public int? ElementId { get; set; }
        public int? UserId { get; set; }
    }
}
