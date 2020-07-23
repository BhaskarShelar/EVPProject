using System;
using System.Collections.Generic;

namespace EVP.Models
{
    public partial class Login
    {
        public int LoginID { get; set; }
        public string Admin { get; set; }
        public string Origanzation { get; set; }
        public string Employee { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Isdeleted { get; set; }
    }
}
