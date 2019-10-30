using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblMailbox
    {
        public int Id { get; set; }
        public string MailNumber { get; set; }
        public int? TypeId { get; set; }
        public int? FromId { get; set; }
        public int? ToId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool? IsRead { get; set; }
        public string RelatedMailNumber { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
