using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblForm
    {
        public int Id { get; set; }
        public string FormNumber { get; set; }
        public int? ModuleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ActionType { get; set; }
        public string SuccessMessage { get; set; }
        public string SuccessUrl { get; set; }
        public int? SourceId { get; set; }
        public string SubmitText { get; set; }
        public string SelectText { get; set; }
        public bool? IsLogo { get; set; }
        public bool? IsPublish { get; set; }
        public bool? IsEmail { get; set; }
        public bool? IsGdpr { get; set; }
        public bool? IsAutoDistribution { get; set; }
        public bool? IsValidate { get; set; }
        public bool? IsAutoAnswer { get; set; }
        public string GdprMessage { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
