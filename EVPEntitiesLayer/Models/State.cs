using System;
using System.Collections.Generic;

namespace EVP.Models
{
    public partial class State
    {
        public State()
        {
            AddressDetails = new HashSet<AddressDetails>();
            Country = new HashSet<Country>();
        }

        public int StateID { get; set; }
        public string StateName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string IsDeleted { get; set; }
        public int? CityID { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<AddressDetails> AddressDetails { get; set; }
        public virtual ICollection<Country> Country { get; set; }
    }
}
