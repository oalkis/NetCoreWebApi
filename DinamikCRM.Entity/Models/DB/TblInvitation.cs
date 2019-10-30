using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblInvitation
    {
        public int Id { get; set; }
        public string InvitationNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool? IsRead { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
