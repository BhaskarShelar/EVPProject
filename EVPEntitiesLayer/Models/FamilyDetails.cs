using System;
using System.Collections.Generic;

namespace EVP.Models
{
    public partial class FamilyDetails
    {
        public int FamilyDetailsID { get; set; }
        public string PersonName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Occupation { get; set; }
        public string Relation { get; set; }
        public string Email { get; set; }
        public string MobileNumbar { get; set; }
        public int? EmployeeID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string IsDeleted { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
