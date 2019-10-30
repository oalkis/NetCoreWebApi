﻿using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblCampaignTempList
    {
        public int Id { get; set; }
        public int? ModuleId { get; set; }
        public string DataNumber { get; set; }
        public int? ProviderId { get; set; }
        public int? TypeId { get; set; }
        public string CampaignNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Result { get; set; }
        public bool? IsActive { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
