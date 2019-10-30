using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblCompanyDetail
    {
        public int Id { get; set; }
        public string CompanyNumber { get; set; }
        public int? TypeId { get; set; }
        public string Title { get; set; }
        public string CompanyContactName { get; set; }
        public string CompanyContactEmail { get; set; }
        public string CompanyContactPhone { get; set; }
        public string Region { get; set; }
        public int? Headcount { get; set; }
        public int? Establishment { get; set; }
        public string Url { get; set; }
        public DateTime? ContractDate { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
