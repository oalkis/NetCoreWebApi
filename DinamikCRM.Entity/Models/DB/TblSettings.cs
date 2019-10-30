using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblSettings
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyUrl { get; set; }
        public bool? IsActiveConsoleReminder { get; set; }
        public bool? IsActiveConsoleBirthdays { get; set; }
        public bool? IsActiveConsoleContractdays { get; set; }
        public bool? IsActiveConsoleSubscriptions { get; set; }
        public bool? IsActiveConsoleDailyReports { get; set; }
        public bool? IsActiveConsoleLastLogin { get; set; }
        public bool? IsActiveConsoleUserSubscription { get; set; }
        public bool? IsActiveStore { get; set; }
        public bool? IsActiveInvitation { get; set; }
    }
}
