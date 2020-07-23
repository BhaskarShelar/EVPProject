using System;
using System.Collections.Generic;

namespace EVP.Models
{
    public partial class EmployeeDocuments
    {
        public int EmployeeDocumentID { get; set; }
        public string DocumentTypeID { get; set; }
        public int? EmployeeID { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
