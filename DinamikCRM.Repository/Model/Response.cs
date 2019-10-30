using System;
using System.Collections.Generic;
using System.Text;

namespace DinamikCRM.Repository.Model
{
   
    public class CustomerListResponse
    {
        public int Id { get; set; }
        public string CustomerNumber { get; set; }
        public string FullName { get; set; }
    }
}
