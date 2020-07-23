using System;
using System.Collections.Generic;

namespace EVP.Models
{
    public partial class City
    {
        public City()
        {
            AddressDetails = new HashSet<AddressDetails>();
            State = new HashSet<State>();
        }

        public int CityID { get; set; }
        public string CityName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string IsDeleted { get; set; }

        public virtual ICollection<AddressDetails> AddressDetails { get; set; }
        public virtual ICollection<State> State { get; set; }
    }
}
