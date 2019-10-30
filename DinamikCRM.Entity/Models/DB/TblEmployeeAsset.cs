using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblEmployeeAsset
    {
        public int Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string AssetNumber { get; set; }
        public string InventoryNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
