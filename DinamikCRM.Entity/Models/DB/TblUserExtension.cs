using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblUserExtension
    {
        public int Id { get; set; }
        public string Extension { get; set; }
        public int? UserId { get; set; }
    }
}
