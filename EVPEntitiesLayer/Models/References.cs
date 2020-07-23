using System;
using System.Collections.Generic;

namespace EVP.Models
{
    public partial class References
    {
        public int ReferenceID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
        public string RelationshipType { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public int? EmployeeID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string IsDeleted { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
