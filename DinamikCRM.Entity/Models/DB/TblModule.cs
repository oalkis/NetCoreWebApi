using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblModule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string Description { get; set; }
        public string DescriptionEn { get; set; }
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public string Keywords { get; set; }
        public string KeywordsEn { get; set; }
        public string VideoUrl { get; set; }
        public string VideoUrlEn { get; set; }
        public bool? Active { get; set; }
    }
}
