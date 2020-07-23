using System;
using System.Collections.Generic;

namespace EVP.Models
{
    public partial class User
    {
        public User()
        {
            Employee = new HashSet<Employee>();
        }

        public int UserID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string IsVarify { get; set; }
        public string UserType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string IsDeleted { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
