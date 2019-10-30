using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DinamikCRM.DinamikCRM.Entity.Models.DB
{
    public abstract class BaseEntity
    {
        private DateTime dateTime;
        [NotMapped]
        public DateTime UsedTime { get { this.dateTime = DateTime.Now; return dateTime; } set { } }
        public void WriteLog()
        {
         
            Console.WriteLine($"UseTime: {UsedTime.ToLongDateString()}");
        }
    }
}
