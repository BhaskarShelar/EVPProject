using System;
using System.Collections.Generic;

namespace EVP.Models
{
    public partial class DocumentType
    {
        public int DocumentTypeID { get; set; }
        public string DocumentTypeName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string IsDeleted { get; set; }
    }
}
