using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblNps
    {
        public int Id { get; set; }
        public string NpsNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Question { get; set; }
        public string LowPointTag { get; set; }
        public string HighPointTag { get; set; }
        public string QuestionDesc { get; set; }
        public string SuccessMessage { get; set; }
        public string ShortUrl { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
