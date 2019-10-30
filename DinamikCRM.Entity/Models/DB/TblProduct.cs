using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblProduct
    {
        public int Id { get; set; }
        public string ProductNumber { get; set; }
        public int? TypeId { get; set; }
        public int? CompanyId { get; set; }
        public int? VendorId { get; set; }
        public int? BrandId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsShared { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
