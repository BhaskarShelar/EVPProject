using System;
using System.Collections.Generic;

namespace EVP.Models
{
    public partial class Country
    {
        public Country()
        {
            AddressDetails = new HashSet<AddressDetails>();
        }

        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string IsDeleted { get; set; }
        public int? StateID { get; set; }

        public virtual State State { get; set; }
        public virtual ICollection<AddressDetails> AddressDetails { get; set; }
    }
}
