using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblVehicle
    {
        public int Id { get; set; }
        public string DealerNumber { get; set; }
        public string VehicleNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DriverName { get; set; }
        public string DriverPhone { get; set; }
        public string UserName { get; set; }
        public bool? IsReady { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
