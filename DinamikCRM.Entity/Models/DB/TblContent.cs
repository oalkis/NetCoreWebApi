using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblContent
    {
        public int Id { get; set; }
        public string ContentNumber { get; set; }
        public int? TypeId { get; set; }
        public int? CategoryId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string VideoUrl { get; set; }
        public string TargetUrl { get; set; }
        public bool? IsCarousel { get; set; }
        public bool? IsMainPage { get; set; }
        public bool? IsComment { get; set; }
        public bool? IsReact { get; set; }
        public bool? IsShare { get; set; }
        public int? SortOrder { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
