using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblCall
    {
        public int Id { get; set; }
        public string CallNumber { get; set; }
        public int? DataTypeId { get; set; }
        public string CompanyNumber { get; set; }
        public string ContactNumber { get; set; }
        public string CustomerNumber { get; set; }
        public string Phone { get; set; }
        public int? TypeId { get; set; }
        public string Cid { get; set; }
        public string Ucid { get; set; }
        public int? CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int? Priority { get; set; }
        public int? ResponseId { get; set; }
        public bool? IsShared { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
