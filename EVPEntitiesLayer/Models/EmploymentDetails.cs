using System;
using System.Collections.Generic;

namespace EVP.Models
{
    public partial class EmploymentDetails
    {
        public int EmploymentDetailsID { get; set; }
        public string EmployeeIDOld { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string IndustryType { get; set; }
        public string Designation { get; set; }
        public string EmployementType { get; set; }
        public string Salary { get; set; }
        public string SNorTLName { get; set; }
        public string SNorTLContactNumber { get; set; }
        public string SNorTLEmail { get; set; }
        public string ReasonforLeaving { get; set; }
        public string EligibleforRehire { get; set; }
        public string AgencyDetails { get; set; }
        public int? EmployeeID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string IsDeleted { get; set; }
        public int? NumberofYearExperince { get; set; }
        public DateTime? DatedFromTill { get; set; }
        public DateTime? DatedToTill { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
