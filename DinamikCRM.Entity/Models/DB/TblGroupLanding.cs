using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblGroupLanding
    {
        public int Id { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsCarousel { get; set; }
        public string Slogan1 { get; set; }
        public string Description1 { get; set; }
        public string Image1 { get; set; }
        public string Slogan2 { get; set; }
        public string Description2 { get; set; }
        public string Image2 { get; set; }
        public string Slogan3 { get; set; }
        public string Description3 { get; set; }
        public string Image3 { get; set; }
        public bool? IsAboutUs { get; set; }
        public bool? IsServices { get; set; }
        public bool? IsProducts { get; set; }
        public bool? IsForms { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
