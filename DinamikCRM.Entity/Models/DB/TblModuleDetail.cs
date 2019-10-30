using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblModuleDetail
    {
        public int Id { get; set; }
        public int? ModuleId { get; set; }
        public string Description { get; set; }
        public string DescriptionEn { get; set; }
        public bool? Active { get; set; }
    }
}
