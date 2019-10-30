using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblCustomerDetail
    {
        public int Id { get; set; }
        public string CustomerNumber { get; set; }
        public string Title { get; set; }
        public int? Position { get; set; }
        public int? Department { get; set; }
        public int? MaritalStatus { get; set; }
        public int? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? MarriageDate { get; set; }
        public int? FavoriteTeam { get; set; }
        public bool? IsHaveAchild { get; set; }
        public string Hobbies { get; set; }
        public int? CountryId { get; set; }
        public int? ServiceId { get; set; }
        public int? LanguageId { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
