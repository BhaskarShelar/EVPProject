using System;
using System.Collections.Generic;

namespace EVP.Models
{
    public partial class EducationDetails
    {
        public int EducationID { get; set; }
        public string Qualification { get; set; }
        public string UnivercityBoard { get; set; }
        public string CollegeSchoolName { get; set; }
        public string Stream { get; set; }
        public string YearofPassing { get; set; }
        public string FullTimePartTime { get; set; }
        public string PercentageGrade { get; set; }
        public string IsYearGap { get; set; }
        public string NumberOfYearGap { get; set; }
        public int? EmployeeID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string IsDeleted { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
