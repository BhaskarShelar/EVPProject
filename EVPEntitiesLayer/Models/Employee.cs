using System;
using System.Collections.Generic;

namespace EVP.Models
{
    public partial class Employee
    {
        public Employee()
        {
            AddressDetails = new HashSet<AddressDetails>();
            EducationDetails = new HashSet<EducationDetails>();
            EmployeeDocuments = new HashSet<EmployeeDocuments>();
            EmploymentDetails = new HashSet<EmploymentDetails>();
            FamilyDetails = new HashSet<FamilyDetails>();
            References = new HashSet<References>();
        }

        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string Gender { get; set; }
        public int? MobileNumber { get; set; }
        public string Email { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string IsDeleted { get; set; }
        public int? UserID { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<AddressDetails> AddressDetails { get; set; }
        public virtual ICollection<EducationDetails> EducationDetails { get; set; }
        public virtual ICollection<EmployeeDocuments> EmployeeDocuments { get; set; }
        public virtual ICollection<EmploymentDetails> EmploymentDetails { get; set; }
        public virtual ICollection<FamilyDetails> FamilyDetails { get; set; }
        public virtual ICollection<References> References { get; set; }
    }
}
