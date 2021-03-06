﻿using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblSalesShipment
    {
        public int Id { get; set; }
        public string ShipmentNumber { get; set; }
        public string SalesNumber { get; set; }
        public int? ProviderId { get; set; }
        public string DataNumber { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
