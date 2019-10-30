using System;
using System.Collections.Generic;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class TblEmployeeDetail
    {
        public int Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string Title { get; set; }
        public int? Position { get; set; }
        public int? Department { get; set; }
        public int? MaritalStatus { get; set; }
        public int? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? JoinDate { get; set; }
        public DateTime? MarriageDate { get; set; }
        public int? FavoriteTeam { get; set; }
        public bool? IsHaveAchild { get; set; }
        public string Hobbies { get; set; }
        public int? LanguageId { get; set; }
        public int? EducationStatusId { get; set; }
        public string SchoolName { get; set; }
        public string Profession { get; set; }
        public string WorkExperiences { get; set; }
        public string CoursesAndCertification { get; set; }
        public string ComputerSkills { get; set; }
        public int? DisabilityId { get; set; }
        public string IdNumber { get; set; }
        public int? EmploymentTypeId { get; set; }
        public int? BloodTypeId { get; set; }
        public int? DrivingLicenceTypeId { get; set; }
        public int? IsPassport { get; set; }
        public string PassportNumber { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Active { get; set; }
    }
}
