using System;
using System.Collections.Generic;

namespace EVP.Models
{
    public partial class AddressDetails
    {
        public int AddressID { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Type { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int? EmployeeID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string IsDeleted { get; set; }
        public int? CountryID { get; set; }
        public int? StateID { get; set; }
        public int? CityID { get; set; }

        public virtual City CityNavigation { get; set; }
        public virtual Country CountryNavigation { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual State StateNavigation { get; set; }
    }
}
